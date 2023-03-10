Delight 2021.1.0
----------------

Check out https://delight-dev.github.io/ for latest API docs, tutorials, extras and news.
Join the Discord chat for engaging with a supportive community: https://discord.gg/9BVyVsB

Introduction
------------

Delight is an open source component-oriented framework for Unity, mainly centered around creating user-interface components that can easily be extended, combined and shared using a text based declarative design language (similar to HTML). Below shows a quick start guide, be sure to check out GettingStarted.pdf for a guide to get started.

Quick Start
-----------

1. Import the package to your project.

2. Create a new scene by right-clicking in your project hierarchy and choosing:

Create -> Delight Scene.

Press enter and open the newly created NewScene.xml XML file and edit it so it contains the following content:

    <NewScene xmlns="Delight" 
              xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" 
              xsi:schemaLocation="Delight ../Delight.xsd">
        <Label Text="Awesome!" />
    </NewScene>

3. Open the Unity scene NewScene.unity that has been created in the same folder and run it.

Congratulations, you’ve created your first scene in Delight :).

Check out the Tutorials at https://delight-dev.github.io/ and get started creating some awesome UI components.

Upgrading from earlier versions
-------------------------------

Remove everything under the Delight folder except the Extensions folder if you have downloaded additional extensions you want to keep. After the files are removed, import the new package. Make sure everything compiles and reload the content by pressing "Reload All" in the Delight window:

Window -> Delight

Package Details
---------------

(required)
Delight\* ..................... Framework source and content

(recommended)
Content\* ..................... Your project's content processed by Delight
Delight\Extensions\ ........... Optional extensions and examples

Contributing
------------

The framework is open source which means anyone is welcome to contribute to the project. You find the project at GitHub: 
https://github.com/delight-dev/Delight

For minor contributions, such as bugfixes, open a pull request. If your contribution is larger, such as new views or features, consider opening an issue first to engage the community.

Sponsoring
----------

If you enjoy the framework and like what I do, consider sponsoring the project as it helps me keep developing it and be of service to the community. Thank you.

https://github.com/sponsors/delight-dev