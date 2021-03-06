IronMQ .NET Client
----------------

Getting Started
===============

[Download the IronMQ Project](https://github.com/iron-io/iron_mq_dotnet/downloads). 

    buildr package

The .dll file will appear in your bin directory.


The Basics
==========
**Initialize** a client and get a queue object:

    Client client = new Client("my project", "my token");	// defualt Host and Port
    Queue queue = client.queue("my_queue");

**Push** a message on the queue:

    queue.Push("Hello, world!");

**Pop** a message off the queue:

    Message msg = queue.get();

When you pop/get a message from the queue, it will *not* be deleted. It will
eventually go back onto the queue after a timeout if you don't delete it. (The
default timeout is 60 seconds)

**Delete** a message from the queue:

    queue.deleteMessage(msg);


Choosing Cloud
==============
**Initialize** a client and get a queue object (Amazon):

    Client client = new Client("my project", "my token", "mq-aws-us-east-1.iron.io");	// Amazon (default)

**Initialize** a client and get a queue object (Rackspace):
  
    Client client = new Client("my project", "my token", "mq-rackspace-dfw.iron.io");	// Rackspace


