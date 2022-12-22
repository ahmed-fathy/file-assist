# File and Log assist
A handy tool that manages text and log files in windows. It helps to generate a CSV report for directory structure, find text and replace content in text files, which can quickly process several files and directly save the results in CSV file. The CSV output can be easily converted to excel sheet or viewable as plain text in notepad.

Features:
- Generates CSV report for file system and directory files, including: file path, name, extension, and size.
- Find content in text files using Regular Expressions and generates CSV report, including: file path, name, and matches count.
- Replace content in text files using Regular Expressions and generates CSV report, including: file path, name, and replacement count.
- Rename files using multiple patterns, such as adding auto-number, append text, or replace part of file name.

## Usage:

Select a directory path or paste a valid path to get started. 

#### 1) Directory files

- File extensions and count will be displayed once you select a valid path.
- You may filter the files extensions, add or remove extensions as desired (separated by comma). 
- After selecting the files, you can generate CSV report for the directory files.  

Please note: the selected files and extensions will be applied to all next steps.

![image](https://user-images.githubusercontent.com/19252601/209031040-24871460-530f-4218-8fae-8d9b4e7d3a1f.png)


#### 2) Find text in files

After selecting the files and extensions in step 1, you can search in the selected files for any text and use Regular Expressions to extend the search. This will generate a CSV report for the files and the matches count.

![image](https://user-images.githubusercontent.com/19252601/209031552-a417bf2d-9e81-4341-a296-cb42ed94ac52.png)


#### 3) Replace text in files

Similarly, you can replace content of the selected files and use Regular Expressions. This will generate a CSV report for the files and the replacements count.

![image](https://user-images.githubusercontent.com/19252601/209031871-fc6e569a-80c9-4aa3-bf11-d7693c30891e.png)


#### 4) Rename files

You can rename the selected files using multiple options.
- Add Text to the beginning/end of file name.
- Add Auto-number to the beginning of file name, such as {number}-Filename.ext
- Ignore files with size greater than a specific size in MB.
- Replace part of the file name.

 Output:
 - New Directory: this will copy and rename all files into a new directory "Renamed Files" in the same directory path.
 - Same directory: rename files in the same directory. Please make sure the files does not exist or the file rename will fail.

Please note: This feature does not delete the original files.  

![image](https://user-images.githubusercontent.com/19252601/209032518-0983cfe9-9f0f-4ecb-90c6-b88138c6aff8.png)
