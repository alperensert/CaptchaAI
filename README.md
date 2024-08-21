# CapSolver.com Library for .NET Core
![Nuget](https://img.shields.io/nuget/dt/CapSolver?style=for-the-badge) ![Nuget](https://img.shields.io/nuget/v/CapSolver?style=for-the-badge) ![GitHub last commit](https://img.shields.io/github/last-commit/alperensert/CapSolver?style=for-the-badge) ![GitHub Release Date](https://img.shields.io/github/release-date/alperensert/CapSolver?style=for-the-badge) ![GitHub Repo stars](https://img.shields.io/github/stars/alperensert/CapSolver?style=for-the-badge)

[CapSolver.com](https://dashboard.capsolver.com/passport/register?inviteCode=kXa8cbNF-b2l) Library for .NET Core. Register now from [here!](https://dashboard.capsolver.com/passport/register?inviteCode=kXa8cbNF-b2l)

### Installation
via Package Manager:
```
NuGet\Install-Package CapSolver -Version 2.0.0
```
This command is intended to be used within the Package Manager Console in Visual Studio, as it uses the NuGet module's version of Install-Package.

via .NET CLI:
```ssh
dotnet add package CapSolver --version 2.0.0
```

via adding PackageReference:
```xml
<PackageReference Include="CapSolver" Version="2.0.0" />
```
For projects that support PackageReference, copy this XML node into the project file to reference the package.

### Supported Captcha Types
- Image To Text
- ReCaptcha V2
- ReCaptcha V2 Classification
- ReCaptcha V3
- HCaptcha
- HCaptcha Classification
- GeeTest
- Datadome Slider / Interstitial
- Anti Turnstile / Cloudflare
- MTCaptcha
- AWS WAF Classification
- Vision Engine Classification

### Usage Examples
---
### Creating a client
```csharp
var client = new CapSolverClient("apikey");
```
### Get balance
```csharp
var client = new CapSolverClient("apikey");
await client.GetBalance();
```
### Get Packages
```csharp
var client = new CapSolverClient("apikey");
await client.GetPackages();
```
#### ReCaptchaV2 Task
```csharp
var client = new CapSolverClient("apikey", false);
var task = new ReCaptchaV2Task("recaptcha-site", "recaptcha-site-key");
string id = await client.CreateTask(task);
var response = await client.JoinTaskResult<ReCaptchaV2Response>(id);
```

#### FunCaptcha Task
```csharp
var client = new CapSolverClient("apikey", false);
var task = new HCaptchaTask("hcaptcha-site", "hcaptcha-key");
string id = await client.CreateTask(task);
var response = await client.JoinTaskResult<HCaptchaResponse>(id);
```

For other examples and api documentation please visit [wiki](https://captchaai.atlassian.net/wiki/spaces/CAPTCHAAI/overview)