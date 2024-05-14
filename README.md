# ReactAuthDemo

This is a simple demo app that shows how to use authentication in a React application with an ASP.Net core backend.

## Setup Instructions

In your **data** project, add a reference to `BCrypt.Net-Next`. You can either do it through the Nuget UI:

<img width="912" alt="image" src="https://github.com/LKWD-2023/ReactAuthDemo/assets/126539919/5c7af3ea-66a4-42a6-9d41-47eecc3af1fe">

or, you can add the following line to your `<ItemGroup>` section of your `.csproj` file:

```
<PackageReference Include="BCrypt.Net-Next" Version="4.0.3" />
```

Then, add the following lines of code to your `Program.cs` file within the **web** project:

https://github.com/LITW11/ReactAuthDemo/blob/master/ReactAuthDemo.Web/Program.cs#L7
[https://github.com/LITW11/ReactAuthDemo/blob/master/ReactAuthDemo.Web/Program.cs#L13-L26](https://github.com/LITW11/ReactAuthDemo/blob/master/ReactAuthDemo.Web/Program.cs#L13-L28)
https://github.com/LITW11/ReactAuthDemo/blob/master/ReactAuthDemo.Web/Program.cs#L41-L43
