The originality check in this project is very simple.
It checks up the original file and takes thread to sleep for 10 seconds. If during these time you arrive to change something in the file it'll tell you that a change occured in the original file. Otherwise, you'll get `true`. ![k13205167](https://cloud.githubusercontent.com/assets/25085025/24134016/e7d97fc6-0e1a-11e7-81e4-3893bc238840.jpg)

Here is the method:
```javascript
public bool IsOriginal(string path)
{
    var entryHash = GetSHA256(path);

    Thread.Sleep(10000); // some heavy work for 10 seconds

    var finalHash = GetSHA256(path);

    return entryHash.Equals(finalHash, StringComparison.Ordinal);
}    
```
