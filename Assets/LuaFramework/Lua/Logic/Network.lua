
require "Common/define"
require "Common/protocal"
require "Common/functions"
Event = require 'events'

require "3rd/pblua/login_pb"
require "3rd/pbc/protobuf"

local sproto = require "3rd/sproto/sproto"
local core = require "sproto.core"
local print_r = require "3rd/sproto/print_r"

local protos = require "Common/proto"

Network = {};
local this = Network;

local transform;
local gameObject;
local islogging = false;
local session = 0

function Network.Start() 
    logWarn("Network.Start!!");
    Network.InitProto()
    Network.ReisterProtoResponse()
    Event.AddListener(Protocal.Connect, this.OnConnect); 
    Event.AddListener(Protocal.Message, this.OnMessage); 
    Event.AddListener(Protocal.Exception, this.OnException); 
    Event.AddListener(Protocal.Disconnect, this.OnDisconnect); 
end

function Network.InitProto()
    local host = sproto.new(protos.s2c):host "package"
    local request = host:attach(sproto.new(protos.c2s))
    Network.host = host
    Network.request = request
end

function Network.ReisterProtoResponse()

end

function Network.Send(name, args)
    session = session + 1
    local package = Network.request(name, args, session)
    local buffer = ByteBuffer.New();
    buffer:WriteBufferWithoutLength(package);
    networkMgr:SendMessage(buffer);
end

--Socket消息--
function Network.OnSocket(key, data)
    logWarn("Network.OnSocket "..tostring(key).." "..tostring(data))
    Event.Brocast(tostring(key), data);
end

--当连接建立时--
function Network.OnConnect() 
    logWarn("Game Server connected!!");
end

--异常断线--
function Network.OnException() 
    islogging = false; 
    NetManager:SendConnect();
   	logError("OnException------->>>>");
end

--连接中断，或者被踢掉--
function Network.OnDisconnect() 
    islogging = false; 
    logError("OnDisconnect------->>>>");
end

--登录返回--
function Network.OnMessage(buffer) 
    logWarn('OnMessage-------->>>');
	if TestProtoType == ProtocalType.BINARY then
		this.TestLoginBinary(buffer);
	end
	if TestProtoType == ProtocalType.PB_LUA then
		this.TestLoginPblua(buffer);
	end
	if TestProtoType == ProtocalType.PBC then
		this.TestLoginPbc(buffer);
	end
    if TestProtoType == ProtocalType.SPROTO then
        local type, key, result = Network.host:dispatch(buffer:ReadBufferWithoutLength())
        logWarn("dispatch")
        logWarn("type "..tostring(type))
        logWarn("key or session "..tostring(key))
        logWarn("result "..tostring(result))
        if result then
            print_package(type, key, result)
        end
	end
	----------------------------------------------------
    -- local ctrl = CtrlManager.GetCtrl(CtrlNames.Message);
    -- if ctrl ~= nil then
    --     ctrl:Awake();
    -- end
end

--二进制登录--
function Network.TestLoginBinary(buffer)
	local protocal = buffer:ReadByte();
	local str = buffer:ReadString();
	log('TestLoginBinary: protocal:>'..protocal..' str:>'..str);
end

--PBLUA登录--
function Network.TestLoginPblua(buffer)
	local protocal = buffer:ReadByte();
	local data = buffer:ReadBuffer();

    local msg = login_pb.LoginResponse();
    msg:ParseFromString(data);
	log('TestLoginPblua: protocal:>'..protocal..' msg:>'..msg.id);
end

--PBC登录--
function Network.TestLoginPbc(buffer)
	local protocal = buffer:ReadByte();
	local data = buffer:ReadBuffer();

    local path = Util.DataPath.."lua/3rd/pbc/addressbook.pb";

    local addr = io.open(path, "rb")
    local buffer = addr:read "*a"
    addr:close()
    protobuf.register(buffer)
    local decode = protobuf.decode("tutorial.Person" , data)

    print(decode.name)
    print(decode.id)
    for _,v in ipairs(decode.phone) do
        print("\t"..v.number, v.type)
    end
	log('TestLoginPbc: protocal:>'..protocal);
end

--SPROTO登录--
function Network.TestLoginSproto(buffer)
	local protocal = buffer:ReadByte();
	local code = buffer:ReadBuffer();

    local sp = sproto.parse [[
    .Person {
        name 0 : string
        id 1 : integer
        email 2 : string

        .PhoneNumber {
            number 0 : string
            type 1 : integer
        }

        phone 3 : *PhoneNumber
    }

    .AddressBook {
        person 0 : *Person(id)
        others 1 : *Person
    }
    ]]
    local addr = sp:decode("AddressBook", code)
    print_r(addr)
	log('TestLoginSproto: protocal:>'..protocal);
end

--卸载网络监听--
function Network.Unload()
    Event.RemoveListener(Protocal.Connect);
    Event.RemoveListener(Protocal.Message);
    Event.RemoveListener(Protocal.Exception);
    Event.RemoveListener(Protocal.Disconnect);
    logWarn('Unload Network...');
end