﻿using LeetCodeCs;

internal static class Program
{
    static void Main()
    {
        #region 1-Two Sum
        //var ouput1 = Two_Sum.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
        //var ouput2 = Two_Sum.TwoSum(new int[] { 3, 2, 4 }, 6);
        //var ouput3 = Two_Sum.TwoSum(new int[] { 3, 3 }, 6);
        #endregion

        #region 2-Add Two Numbers (uncomplete)
        /*Add_Two_Numbers atn = new Add_Two_Numbers();

        //l1 = 2->4->3
        ListNode l1 = new ListNode(2);
        l1.next = new ListNode(4);
        l1.next.next = new ListNode(3);
        //l2 = 5->6->4
        ListNode l2 = new ListNode(5);
        l2.next = new ListNode(6);
        l2.next.next = new ListNode(4);
        //output1 = 7->2->8
        var output1 = atn.AddTwoNumbers(l1, l2);*/
        #endregion

        #region 9-Palindrome number
        Palindrome_Number pn = new Palindrome_Number();
        int v1 = 121;
        int v2 = -121;
        int v3 = 10;
        Console.WriteLine($"{v1} is palindrome: {pn.PalindromeNumber(v1)}");
        Console.WriteLine($"{v2} is palindrome: {pn.PalindromeNumber(v2)}");
        Console.WriteLine($"{v3} is palindrome: {pn.PalindromeNumber(v3)}");
        #endregion
    }
}