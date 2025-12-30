
<div align="center">

[![License][shield-repo-license]][repo-license]
[![GitHub Workflow Status][shield-repo-workflow]][repo-actions]
[![Crowdin][shield-crowdin-status]][crowdin-project]
[![Downloads][shield-repo-releases]][repo-releases]
[![Version][shield-repo-latest]][repo-latest]
[![Discord][shield-discord-server]][discord-invite]
[![lol][shield-tenor-meme]][tenor-gif]

</div>

----

AetherStrap is a third-party replacement for the standard Roblox bootstrapper, providing additional useful features and improvements.

Running into a problem or need help with something? [Check out the Wiki](https://github.com/AetherStraplabs/AetherStrap/wiki). If you can't find anything, or would like to suggest something, please [submit an issue](https://github.com/AetherStraplabs/AetherStrap/issues).

AetherStrap is only supported for PCs running Windows.

## Frequently Asked Questions

**Q: Is this malware?**

**A:** No. The source code here is viewable to all, and it'd be impossible for us to slip anything malicious into the downloads without anyone noticing. Just be sure you're downloading it from an official source. The only two official sources are this GitHub repository 

**Q: Can using this get me banned?**

**A:** No, it shouldn't. AetherStrap doesn't interact with the Roblox client in the same way that exploits do. [Read more about that here.](https://github.com/AetherStraplabs/AetherStrap/wiki/Why-it's-not-reasonably-possible-for-you-to-be-banned-by-AetherStrap)

## Features

- Hassle-free Discord Rich Presence to let your friends know what you're playing at a glance
- Simple support for modding of content files for customizability (death sound, mouse cursor, etc)
- See where your server is geographically located (courtesy of [ipinfo.io](https://ipinfo.io))
- Ability to configure graphics fidelity and UI experience

## Installing
Download the [latest release of AetherStrap](https://github.com/AetherStraplabs/AetherStrap/releases/latest), and run it. Configure your preferences if needed, and install. That's about it!

Alternatively, you can install AetherStrap via [Winget](https://winstall.app/apps/pizzaboxer.AetherStrap) by running this in a Command Prompt window:
```
> winget install AetherStrap
```

You will also need the [.NET 6 Desktop Runtime](https://aka.ms/dotnet-core-applaunch?missing_runtime=true&arch=x64&rid=win11-x64&apphost_version=6.0.16&gui=true). If you don't already have it installed, you'll be prompted to install it anyway. Be sure to install AetherStrap after you've installed this.

It's not unlikely that Windows Smartscreen will show a popup when you run AetherStrap for the first time. This happens because it's an unknown program, not because it's actually detected as being malicious. To dismiss it, just click on "More info" and then "Run anyway".

Once installed, AetherStrap is added to your Start Menu, where you can access the menu and reconfigure your preferences if needed.

## Code

AetherStrap uses the [WPF UI](https://github.com/lepoco/wpfui) library for the user interface design. We currently use and maintain our own fork of WPF UI at [AetherStraplabs/wpfui](https://github.com/AetherStraplabs/wpfui).


[shield-repo-license]:  https://img.shields.io/github/license/AetherStraplabs/AetherStrap
[shield-repo-workflow]: https://img.shields.io/github/actions/workflow/status/AetherStraplabs/AetherStrap/ci-release.yml?branch=main&label=builds
[shield-repo-releases]: https://img.shields.io/github/downloads/AetherStraplabs/AetherStrap/latest/total?color=981bfe
[shield-repo-latest]:   https://img.shields.io/github/v/release/AetherStraplabs/AetherStrap?color=7a39fb

[shield-crowdin-status]: https://badges.crowdin.net/AetherStrap/localized.svg
[shield-discord-server]: https://img.shields.io/discord/1099468797410283540?logo=discord&logoColor=white&label=discord&color=4d3dff
[shield-tenor-meme]:     https://img.shields.io/badge/mom_made-pizza_rolls-orange

[repo-license]:  https://github.com/AetherStraplabs/AetherStrap/blob/main/LICENSE
[repo-actions]:  https://github.com/AetherStraplabs/AetherStrap/actions
[repo-releases]: https://github.com/AetherStraplabs/AetherStrap/releases
[repo-latest]:   https://github.com/AetherStraplabs/AetherStrap/releases/latest

[crowdin-project]: https://crowdin.com/project/AetherStrap
[discord-invite]:  https://discord.gg/nKjV3mGq6R
[tenor-gif]:       https://media.tenor.com/FIkSGbGycmAAAAAd/manly-roblox.gif

## Code signing policy

Thanks to [SignPath.io](https://signpath.io/) for providing a free code signing service, and the [SignPath Foundation](https://signpath.org/) for providing the free code signing certificate.
