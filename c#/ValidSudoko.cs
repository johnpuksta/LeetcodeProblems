using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    public class ValidSudoko
    {
        public bool IsValidSudoku(char[][] board) {
            bool Validator = false;
            List<char> allVals = new List<char>(81);
            for (int i = 0; i < 9; i++){
                Validator = CheckList(board[i].ToList());
                if(Validator == false){
                    return false;
                }
                allVals.AddRange(board[i].ToList());
            }
            List<char> tempList = new List<char>(9);
            for (int j = 0; j < 9; j++)
            {
                char[] input = {allVals[j], allVals[j + 9],allVals[j+18],allVals[j+27] ,allVals[j+36] ,allVals[j+45] ,allVals[j+54] ,allVals[j+63] ,allVals[j+72]};
                tempList.AddRange(input);
                Validator = CheckList(tempList);
                if(Validator == false){
                    return false;
                }
                tempList.Clear();
            }
            int iterator = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 9; j += 3)
                {
                    char[] input = { allVals[j + iterator], allVals[j + 1 + iterator], allVals[j + 2 + iterator], allVals[j + 9 + iterator], allVals[j + 10 + iterator], allVals[j + 11 + iterator], allVals[j + 18 + iterator], allVals[j + 19 + iterator], allVals[j + 20 + iterator] };
                    tempList.AddRange(input);
                    Validator = CheckList(tempList);
                    if (Validator == false)
                    {
                        return false;
                    }
                    tempList.Clear();
                }
                iterator += 27;
            }
            return true;

        }
        public bool CheckList(List<char> L){
            L.RemoveAll(s => s == '.');
            if(L.Count != L.Distinct().Count())
            {
                return false;
            }
            return true;
        }
    }
}
/*          Program.cs
            char[][] board = new char[9][];
            for (int i = 0; i < 9; i++){
                board[i] = new char[9];
            }
            char[] row1 = { '5', '3', '.', '.', '7', '.', '.', '.', '.' };
            board[0] = row1;
            char[] row2 = { '6','.','.','1','9','5','.','.','.'};
            board[1] = row2;
            char[] row3 = { '.','9','8','.','.','.','.','6','.'};
            board[2] = row3;
            char[] row4 = {'8','.','.','.','6','.','.','.','3' };
            board[3] = row4;
            char[] row5 = {'4','.','.','8','.','3','.','.','1'};
            board[4] = row5;
            char[] row6 = { '7','.','.','.','2','.','.','.','6' };
            board[5] = row6;
            char[] row7 = {'.','6','.','.','.','.','2','8','.' };
            board[6] = row7;
            char[] row8 = { '.','.','.','4','1','9','.','.','5'};
            board[7] = row8;
            char[] row9 = { '.','.','.','.','8','.','.','7','9' };
            board[8] = row9;

            ValidSudoko test = new ValidSudoko();
            bool val = test.IsValidSudoku(board);
*/