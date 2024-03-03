from ipaddress import ip_address
import socket 

ip_address = "local address"
port_number = 4570

#here we're going to upen up a connectivity method by using ipv4, TCP
#and then state a port for our connection to use.
server_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

server_socket.bint((ip_address, port_number))
#now the socket is bound to the addressing descriptors we've passed to it.

server_socket.listen(2)

client_socket,address = server_socket,accept()
#now we can accept any incoming connection req's

msg =client.socket.recv(1024)#this is a transmission limit 

print(msg)

client_socket.close()#these are to close out the connections once we've 
server_socket.close()#received our message of a specified length
