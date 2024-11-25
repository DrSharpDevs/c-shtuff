#include <stdio.h>
#include <math.h> // Include for pow function
#define _CRT_SECURE_NO_WARNINGS

// Function Prototypes
void get_bands(int* b1, int* b2, int* b3);
int convert_band(char band_char);
int calc_res(int tens, int ones, int exp);

// Main Function
int main() {
    setvbuf(stdout, NULL, _IONBF, 0); // Correct buffer setting
    int b1, b2, b3;
    char cont = 'y';

    while (cont == 'y' || cont == 'Y') {
        get_bands(&b1, &b2, &b3);

        if (b1 == -1 || b2 == -1 || b3 == -1) {
            printf("Invalid Color Combo. Try Again Noob\n");
        }
        else {
            int resistor_value = calc_res(b1, b2, b3);
            printf("Resistor value: %d ohms\n", resistor_value);
        }

        printf("Do you want another resistor? (y/n): ");
        scanf(" %c", &cont); // Use standard scanf
    }
    return 0;
}

// Function to get the 3 band values from the user
void get_bands(int* b1, int* b2, int* b3) {
    char band1, band2, band3;
    printf("Enter the first band color (digit): ");
    scanf(" %c", &band1);
    printf("Enter the second band color (digit): ");
    scanf(" %c", &band2);
    printf("Enter the third band color (exponent): ");
    scanf(" %c", &band3);

    *b1 = convert_band(band1);
    *b2 = convert_band(band2);
    *b3 = convert_band(band3);
}

// Function to convert the band color to numeric value
int convert_band(char band_char) {
    switch (band_char) {
    case 'b': return 0;
    case 'n': return 1;
    case 'r': return 2;
    case 'o': return 3;
    case 'y': return 4;
    case 'g': return 5;
    case 'l': return 6;
    case 'v': return 7;
    case 'e': return 8;
    case 'w': return 9;
    default: return -1; // Handle invalid input
    }
}

// Function to calculate resistor values
int calc_res(int tens, int ones, int exp) {
    int base = tens * 10 + ones;
    int multiplier = 1;
    while (exp > 0) { // Use integer math for exponentiation
        multiplier *= 10;
        exp--;
    }
    return base * multiplier;
}