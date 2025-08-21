# 🛒 MyWebApp E-commerce Platform

A modern, responsive E-commerce web application built with ASP.NET Core MVC. Features a beautiful UI, product catalog, quick view modal, and product details pages. Perfect as a starter template for online stores or .NET web projects.

---
 
## ✨ Features

- Modern, mobile-friendly E-commerce design
- Product catalog with images, badges, ratings, and categories  
- Quick View modal for instant product previews
- Dedicated product details pages
- Promotional carousel and newsletter signup
- Built with ASP.NET Core MVC (.NET 8)
- Easily customizable and extendable

---

## 🚀 Screenshots

> _Add your own screenshots here!_

| Home Page | Product Quick View | Product Details |
|---|---|---|
| ![Home](docs/screenshot-home.png) | ![Quick View](docs/screenshot-quickview.png) | ![Details](docs/screenshot-details.png) |

---

## 🛠️ Getting Started

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)

### Run Locally
```bash
# Clone the repo
 git clone <your-repo-url>
 cd MyWebApp

# Restore dependencies
 dotnet restore

# Run the app
 dotnet run
```
Visit [http://localhost:5000](http://localhost:5000) in your browser.

### Publish for Production
```bash
dotnet publish -c Release -o ./publish
```
Deploy the contents of the `publish` folder to your preferred host (Azure, IIS, Linux, etc.).

---

## 🌐 Deployment
- **Azure App Service:** Easiest for .NET apps ([docs](https://docs.microsoft.com/en-us/azure/app-service/quickstart-dotnetcore))
- **IIS/Windows Server:** Use the .NET Hosting Bundle
- **Linux:** Use `dotnet MyWebApp.dll` and a reverse proxy (Nginx/Apache)

---

## 🙏 Credits
- [Unsplash](https://unsplash.com/) for demo images
- [Bootstrap](https://getbootstrap.com/) for UI components
- [FontAwesome](https://fontawesome.com/) for icons

---

## 📄 License
MIT (or your preferred license)


