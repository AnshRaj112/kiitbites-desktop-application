# KIITBites - Desktop Application

## Introduction
The **KIITBites Desktop Application** is the frontend solution for the KIITBites platform, designed specifically for desktop users. It enables students and food vendors to seamlessly order food, track their orders in real-time, and receive notifications about their purchases. Built using **React Native for Windows/macOS**, the desktop app ensures a smooth and efficient user experience across operating systems.

## Tech Stack
- **Framework:** React Native for Windows/macOS
- **State Management:** Redux Toolkit
- **UI Components:** React Native Paper
- **Navigation:** React Navigation
- **Network Requests:** Axios
- **Real-Time Updates:** Socket.io
- **Authentication:** Firebase Auth, JWT
- **Push Notifications:** Expo Notifications

## Features
- **User Authentication** (Google OAuth, Email/Password login)
- **Food Ordering System** with real-time tracking
- **Cart Management** (Add, remove, modify items before checkout)
- **Payment Integration** (UPI, Card, Wallets)
- **Push Notifications** (Order status, special offers)
- **Order Tracking** (Live updates from preparation to pickup)
- **User Profile & Preferences** (Saved addresses, order history)

## Environment Variables
Create a `.env` file in the root directory and configure the following variables:
```
NEXT_PUBLIC_GOOGLE_CLIENT_ID=your_google_client_id
GOOGLE_CLIENT_ID=your_google_client_id
GOOGLE_CLIENT_SECRET=your_google_client_secret
NEXT_PUBLIC_BACKEND_URL=your_backend_url
BACKEND_URL=your_backend_url
FIREBASE_API_KEY=your_firebase_api_key
FIREBASE_AUTH_DOMAIN=your_firebase_auth_domain
```

## Installation & Setup
### Prerequisites
- Node.js and npm installed
- React Native for Windows/macOS setup (`npx react-native-windows-init` for Windows or `npx react-native-macos-init` for macOS)

### Installation Steps
1. **Fork the repository** on GitHub.
2. **Clone the repository**:
   ```bash
   git clone https://github.com/your-repo/KIITBites-Desktop.git
   cd KIITBites-Desktop
   ```
3. **Install dependencies**:
   ```bash
   npm install
   ```
4. **Create a new branch** following the naming convention:
   - For new features: `features/feature-name`
   - For bug fixes: `fixes/fix-name/feature-name`
   ```bash
   git checkout -b features/your-feature-name
   ```

### Running the Desktop Application
```bash
npx react-native run-windows   # For Windows
npx react-native run-macos     # For macOS
```
The application will launch in a dedicated desktop window.

## Contributing
1. Fork the repository.
2. Create a new branch (`git checkout -b features/feature-name` or `fixes/fix-name/feature-name`).
3. Commit your changes (`git commit -m 'Added new feature'`).
4. Push to your branch (`git push origin features/feature-name`).
5. Open a pull request.

## License
This project is licensed under the MIT License.

## Contact
For queries or contributions, contact the **KIITBites Team** at [kiitbites@gmail.com](mailto:kiitbites@gmail.com).

## Design Reference
Figma Link: [Click Here](https://www.figma.com/design/uCTZfzhDkk06FNwA2Ooc4G/KIITBites?node-id=0-1&t=eN4BzoUfe3aSVfNt-0)
