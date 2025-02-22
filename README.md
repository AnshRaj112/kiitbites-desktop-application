# KIITBites - Desktop Application

## Introduction
The **KIITBites Desktop Application** is a dedicated solution for desktop users, allowing students and vendors to efficiently manage food orders, track inventory, and receive real-time updates. Built using **.NET and C#**, the desktop app ensures a high-performance experience across Windows and macOS environments.

## Tech Stack
- **Framework:** .NET (WPF for Windows, MAUI for cross-platform)
- **Programming Language:** C#
- **Database:** MongoDB with Mongoose
- **State Management:** MVVM (Model-View-ViewModel) Pattern
- **Networking:** HttpClient for API Requests
- **Real-Time Updates:** SignalR
- **Authentication:** JWT, OAuth (Google Sign-In)
- **UI Components:** XAML (Windows) / Blazor Hybrid (macOS)

## Features
- **User Authentication** (Google OAuth, Email/Password login)
- **Food Ordering System** with real-time tracking
- **Multi-Food Court Integration** (View all food courts, check menus, and availability)
- **Cart Management** (Add, remove, modify items before checkout)
- **Payment Integration** (UPI, Card, Wallets)
- **Order Tracking** (Live updates from preparation to pickup)
- **Vendor Dashboard** (Manage orders, track sales, update menus)
- **Offline Mode** (Orders can be placed and synced later)

## Environment Variables
Create an `appsettings.json` file in the root directory and configure the following variables:
```
{
  "GoogleClientId": "your_google_client_id",
  "GoogleClientSecret": "your_google_client_secret",
  "BackendUrl": "your_backend_url",
  "DatabaseConnection": "your_mongodb_connection_string",
  "JwtSecret": "your_jwt_secret"
}
```

## Installation & Setup
### Prerequisites
- .NET SDK installed
- MongoDB setup

### Installation Steps
1. **Fork the repository** on GitHub.
2. **Clone the repository**:
   ```bash
   git clone https://github.com/your-repo/KIITBites-Desktop.git
   cd KIITBites-Desktop
   ```
3. **Install dependencies**:
   ```bash
   dotnet restore
   ```
4. **Create a new branch** following the naming convention:
   - For new features: `features/feature-name`
   - For bug fixes: `fixes/fix-name`
   ```bash
   git checkout -b features/your-feature-name
   ```

### Running the Desktop Application
#### Windows (WPF):
```bash
cd KIITBites.WPF
dotnet run
```
#### Cross-Platform (MAUI for macOS & Windows):
```bash
cd KIITBites.MAUI
dotnet build
``` 
Run the generated executable for your platform.

## Contributing
1. Fork the repository.
2. Create a new branch (`git checkout -b features/feature-name` or `fixes/fix-name`).
3. Commit your changes (`git commit -m 'Added new feature'`).
4. Push to your branch (`git push origin features/feature-name`).
5. Open a pull request.

## License
This project is licensed under the MIT License.

## Contact
For queries or contributions, contact the **KIITBites Team** at [kiitbites@gmail.com](mailto:kiitbites@gmail.com).

## Design Reference
Figma Link: [Click Here](https://www.figma.com/design/uCTZfzhDkk06FNwA2Ooc4G/KIITBites?node-id=0-1&t=eN4BzoUfe3aSVfNt-0)
