# PSP2SDbgpGUI

A graphical tool to interact with the SceDeci4pSDbgp module from internal firmwares using PSP2TMAPI.

This repository also includes a module to load SceDeci4pSDbgp on a PDEL running firmware 3.65 in the `loader` directory.

# Features

This tool only exposes a very tiny subset of the API provided by `SceDeci4pSDbgp`, and does not decode packets.

* Kill/Suspend/Resume processes
* Read arbitrary virtual memory from processes
* Read/write arbitrary physical memory
* `kshow`
    * Various kernel debugging features
* Ability to send custom commands

# Special Thanks

[Princess of Sleeping](https://github.com/Princess-of-Sleeping) for the [psp2sdbgp-host](https://github.com/Princess-of-Sleeping/psp2sdbgp-host) proof of concept