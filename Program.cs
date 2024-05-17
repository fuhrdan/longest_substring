#include <stdio.h>
#include <strings.h>

int lengthOfLongestSubstring(char* s) {
    int len = strlen(s);
    int result = 0;
    for (int x = 0; x < len; x++)
    {
        bool visited[285];
        for (int i = x; i < 285; i++) // reset and initialize boolean value
            visited[i] = false;         // even though this will kill my time and memory usage.
        for (int y = x; y < len; y++)
        {
//            printf("Current Letter = %c and result = %b\n",s[y],visited[s[y]]);
            if (visited[s[y]] == true)
                break;
            else
            {
                if ((y - x + 1 ) >= result)
                {
                    result = (y - x + 1);
                }
                visited[s[y]] = true;
            }
        }
        visited[s[x]] = false;
    }
    return result;
}

int main()
{
    string str = "abcabc";
    printf("The input string is : %s\n", str);
    int len = lengthOfLongestSubstring(str);
    printf("The longth of the longest non-repeating character substring is : %d\n", len);
    return 0;
}