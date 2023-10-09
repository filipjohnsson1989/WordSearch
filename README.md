# Word Search Engine

## Overview
This is a command line tool that searches a word dictionary for words matching specific rules. The rules include checking for isograms, palindromes, semordnilaps, maximum/minimum lengths, prefixes, suffixes, and words containing only specified characters.

## Rules
The tool supports the following rules:
- **class={isogram|palindrome|semordnilap}**: Filters words based on their class (isogram, palindrome, or semordnilap).
- **maxlength=<INT>**: Filters words based on the maximum length.
- **minlength=<INT>**: Filters words based on the minimum length.
- **startswith=<head>**: Filters words that start with a specified prefix.
- **endswith=<tail>**: Filters words that end with a specified suffix.
- **containsonly=<characters>**: Filters words that contain only specified characters.

## Examples
- To search for palindromes that are at most eight letters long:
    ```bash
    dotnet run -- class=palindrome maxlength=8
    ```

- To search for words that are exactly three letters long:
    ```bash
    dotnet run -- maxlength=3 minlength=3
    ```

- To search for words that start with "ba":
    ```bash
    dotnet run -- startswith=ba
    ```

- To search for words that contain only the characters "abcde":
    ```bash
    dotnet run -- containsonly=abcde
    ```

## How to Use
1. Clone this repository to your local machine.
2. Navigate to the project folder.
3. Open a terminal and run:
    ```bash
    dotnet run -- [rules]
    ```
   Replace `[rules]` with your desired rules in the format `ruleType=argument`. You can use multiple rules by separating them with spaces.

## Running Tests
1. Navigate to the project folder.
2. Open a terminal and run:
    ```bash
    dotnet test
    ```

## Contributions
Contributions are welcome! If you have an idea for an improvement or found a bug, please create an issue or a pull request.

## License
This project is licensed under the MIT License.
# WordSearch
