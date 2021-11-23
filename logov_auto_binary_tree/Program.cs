using System;

namespace logov_auto_binary_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>(24, null);
            binaryTree.add(30);
            binaryTree.add(12);
            binaryTree.add(35);
            binaryTree.add(55);
            binaryTree.add(1);
            binaryTree.secondPrint();
            Console.WriteLine($"Высота данного бинарного дерева равна: {binaryTree.Height}");
            Console.WriteLine($"Удаляем все вершины на уровне {Math.Floor((double) binaryTree.Height / 2)}");
            binaryTree.removeLevel();
            Console.WriteLine();
            binaryTree.secondPrint();

        }
    }
}
