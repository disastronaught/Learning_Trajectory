from ipaddress import ip_address
import socket

ip_address = 'x.x.x.x'
port_number = 4570

cs = socket.socket(socket.AF_INET,socket.SOCK_STREAM)

cs.connect((ip_address,port_number))
msg = input("Enter msg to send: ")

while msg!='quit'
    cs.send(msg.encode())
    msg = cs.recv(1024).decode()
    print(msg)
    msg = input("Enter msg to send: ")
#much like a reverse shell, we'll be stating that the target here
#is the transmitting party, whereas our C2 server is in 'listen' mode
#or is doing the receiving

msg = "connection established"

cs.send(msg.encode())

cs.close()
