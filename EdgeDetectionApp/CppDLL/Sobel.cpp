#include "pch.h"
#include "Sobel.h"
#include <cmath>
#include <algorithm>

// Sobel operator kernels
static const int KernelX[3][3] = {
    { 1,  0, -1 },
    { 2,  0, -2 },
    { 1,  0, -1 }
};

static const int KernelY[3][3] = {
    { 1,  2,  1 },
    { 0,  0,  0 },
    { -1, -2, -1 }
};

extern "C" __declspec(dllexport) void __cdecl CppSobelFunction(const unsigned char* sourceImage, unsigned char* resultImage, int imageWidth, int imageHeight) {
    // Set the first and last row to 0 (black border)
    for (int col = 0; col < imageWidth; col++) {
        resultImage[col] = 0;
        resultImage[(imageHeight - 1) * imageWidth + col] = 0;
    }

    // Set the first and last column to 0 (black border)
    for (int row = 0; row < imageHeight; row++) {
        resultImage[row * imageWidth] = 0;
        resultImage[row * imageWidth + (imageWidth - 1)] = 0;
    }

    // Apply the Sobel operator to each pixel in the image, excluding the borders
    for (int row = 1; row < imageHeight - 1; row++) {
        for (int col = 1; col < imageWidth - 1; col++) {
            int gradientX = 0;
            int gradientY = 0;

            // Compute gradients in X and Y directions
            for (int offsetY = -1; offsetY <= 1; offsetY++) {
                for (int offsetX = -1; offsetX <= 1; offsetX++) {
                    int pixelValue = sourceImage[(row + offsetY) * imageWidth + (col + offsetX)];
                    gradientX += pixelValue * KernelX[offsetY + 1][offsetX + 1]; // konwolucja obrazu i j¹der(kernels)
                    gradientY += pixelValue * KernelY[offsetY + 1][offsetX + 1];
                }
            }

            // Compute the magnitude of the gradient
            int gradientMagnitude = abs(gradientX) + abs(gradientY); // obliczanie gradientu 
            if (gradientMagnitude > 255)
                gradientMagnitude = 255;

            //if (gradientMagnitude < 128)
            //    gradientMagnitude = 0;

            // Store the result
            resultImage[row * imageWidth + col] = static_cast<unsigned char>(gradientMagnitude);
        }
    }
}
