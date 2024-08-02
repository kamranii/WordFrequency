Task Description:
Implement a console application in C# that will output a list of the 10 most frequently used words whose length exceeds a specified value.
The words should be counted across multiple text files in a specified folder.
The application should perform the counting in a multithreaded manner.

Treat this task as if it were a real project. I will be happy to answer any questions.
Anything not specified in the requirements, interpret and implement as you see fit.
I will be looking at the speed of execution on large (hundreds of megabytes) files, as well as memory and CPU usage.


Solution - Word Frequency Counter
Description
The Word Frequency Counter is a console application written in C#. This application reads multiple text files from a specified directory and identifies the top 10 most frequently used words that exceed a given length. The application processes the files in a multithreaded manner to enhance performance and sorts the words by frequency and length in descending order.

Features
Reads all text files in a specified directory.
Counts word occurrences across multiple files.
Filters words by a specified minimum length.
Sorts the results by frequency and word length in descending order.
Utilizes multithreading to improve performance on large datasets.

Requirements
.NET Core SDK
A directory containing text files for processing

Installation
Clone the repository:git clone https://github.com/your-repo/word-frequency-counter.git

cd word-frequency-counter

Build the project:dotnet build
Usage
Run the application:dotnet run

Follow the prompts:
Enter the directory path containing the text files.
Enter the minimum word length for filtering.

Example:
Enter the directory path:
C:\path\to\your\textfiles
Enter the minimum word length:
5

Output:
Top 10 most frequently used words:
example: 15
frequency: 12
counter: 10
...
