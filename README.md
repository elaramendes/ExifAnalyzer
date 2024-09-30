# ExifAnalyzer

This project is an attempt to replicate an application that analyzes EXIF metadata in images, originally developed in Python, now implemented in C#.

## Objective

The goal of this project is to provide a tool that allows users to select an image and view the associated EXIF metadata, which contains information about the camera, image settings, and other relevant details.

## Features

- Image selection in common formats (JPG, JPEG, PNG).
- Reading and displaying EXIF metadata, including:
  - Camera make
  - Camera model
  - Date and time the photo was taken
  - Camera settings (exposure, aperture, etc.)

## How to Use

1. **Clone this repository**:
   ```bash
   git clone https://github.com/your_username/ExifAnalyzer.git
   ```
   
2. **Open the project in Visual Studio**:
   - Navigate to the cloned project folder and open the `.sln` file in Visual Studio.

3. **Run the project**:
   - Build and run the application.
   - Select an image using the graphical interface.
   - The EXIF metadata will be displayed in the console.

## Technologies Used

- **C#**: Programming language used to implement the application.
- **Windows Forms**: Framework for building the user interface.
- **MetadataExtractor**: Library for reading EXIF metadata from images.

## Contribution

Contributions are welcome! Feel free to submit a Pull Request or open an Issue.

## License

This project is licensed under the [MIT License](LICENSE.txt).

Feel free to modify any sections to better fit your project's details!