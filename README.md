# CvsCSharp

this is a simple project to compare C and C# performances in computational tasks
you can test this by your self by running **compile.bat** first then **run.bat**

in run.bat you can change how many times you want to run each test

you can automate it by someting like
```
for /l %%x in (1,1,%%count) do 
```
and then run your stuff there

don't forget to redirect the standard output to a file
```.run.bat >> results.txt```

## Results so far:

|**language** | itterations | avg. time taken | min | max
|--------|:-------------:|:------------------:|:-----:|----:
|c|10|0.555555556|0|1
|c#|10|1.222222222|1|2
|--------|-------------|------------------|-----|----|
|c|1000|68.77777778|66|73
|c#|1000|73.55555556|71|83
|--------|-------------|------------------|-----|----|
|c|100000|7186.5|7112|7242
|c#|100000|8071.25|7757|8520
|--------|-------------|------------------|-----|----|

