local fs = {}
function fs.create(name,path,data)
    local f = assert(io.open(path+name, "w"))
    f:write(data)
end
fs.create("bruh69.txt","C:/Users/Levi/","yessir")