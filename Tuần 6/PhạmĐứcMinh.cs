using System;

class Program
{
    static int N = 8; // Kích thước bàn cờ
    static int[] dx = { 2, 1, -1, -2, -2, -1, 1, 2 }; // Tọa độ x của các bước đi của mã
    static int[] dy = { 1, 2, 2, 1, -1, -2, -2, -1 }; // Tọa độ y của các bước đi của mã

    static bool IsSafe(int x, int y, int[,] board)
    {
        // Kiểm tra xem ô (x, y) trên bàn cờ có an toàn để đi hay không
        return (x >= 0 && x < N && y >= 0 && y < N && board[x, y] == -1);
    }

    static void PrintSolution(int[,] board)
    {
        // In ra giải pháp của bài toán mã đi tuần
        for (int x = 0; x < N; x++)
        {
            for (int y = 0; y < N; y++)
            {
                Console.Write(board[x, y] + "\t");
            }
            Console.WriteLine();
        }
    }

    static bool SolveKnightTour(int x, int y, int moveCount, int[,] board)
    {
        // Kiểm tra xem đã hoàn thành bài toán mã đi tuần chưa
        if (moveCount == N * N)
        {
            PrintSolution(board);
            return true;
        }

        // Thử tất cả các bước đi có thể của mã
        for (int i = 0; i < 8; i++)
        {
            int nextX = x + dx[i];
            int nextY = y + dy[i];
            if (IsSafe(nextX, nextY, board))
            {
                board[nextX, nextY] = moveCount;
                if (SolveKnightTour(nextX, nextY, moveCount + 1, board))
                {
                    return true;
                }
                else
                {
                    board[nextX, nextY] = -1; // Quay lui
                }
            }
        }

        return false;
    }

    static void Main()
    {
        int[,] board = new int[N, N];
        for (int x = 0; x < N; x++)
        {
            for (int y = 0; y < N; y++)
            {
                board[x, y] = -1; // Khởi tạo bàn cờ với các ô chưa được đi qua
            }
        }

        int startX = 0; // Vị trí ban đầu của mã theo tọa độ x
        int startY = 0; // Vị trí ban đầu của mã theo tọa độ y
        board[startX, startY] = 0; // Đánh dấu ô ban đầu đã đi qua
        if (!SolveKnightTour(startX, startY, 1, board))
        {
            Console.WriteLine("Không có giải pháp cho bài toán mã đi tuần với kích thước " + N + "x" + N);
        }
    }
}

