
MessageWatcher = {}
MessageWatcher.data = {}

function MessageWatcher.register(name, handler)
    MessageWatcher.data["msg_"..tostring(name)] = handler
end

--- 注册消息
function MessageWatcher.init()
    
end
