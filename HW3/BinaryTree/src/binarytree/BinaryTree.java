/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package binarytree;

/**
 * Node class uses
 *
 * @author Kevin
 */
class Node implements Comparable {

    private int data;
    private Node left, right;

    public Node(int item) {
        data = item;
        left = right = null;
    }

    /**
     * Compares current node value with input node returns 1 if input is greater
     * than current node returns -1 if input is less than current node
     *
     * @param input
     * @return
     */
    @Override
    public int compareTo(Object input) {
        Node node = (Node) input;
        if (node.data > this.data) {
            return 1;
        } else {
            return -1;
        }
    }

    /**
     * Recursive method to insert node based on integer value
     *
     * @param node
     */
    public void insert(Node node) {
        //input node > current node go right
        if (compareTo(node) == 1) {
            if (this.right == null) {
                this.right = node;
            } else {
                this.right.insert((node));
            }
            //input node < = current node go leff
        } else {
            if (this.left == null) {
                this.left = node;
            } else {
                this.left.insert(node);
            }
        }
    }

    public int getData() {
        return data;
    }

    public void setData(int data) {
        this.data = data;
    }
}

/**
 * Client class creates root and inserts nodes into binary tree
 *
 * @author Kevin
 */
class BinaryTree {

    Node root;

    BinaryTree(int key) {
        root = new Node(key);
    }

    BinaryTree() {
        root = null;
    }

    /**
     * insert method that can handle root being null or calls node insert method
     *
     * @param node
     */
    public void insert(Node node) {
        if (root == null) {
            root = node;
        } else {
            root.insert(node);
        }
    }
}

/**
 * Client method creates tree and adds nodes
 *
 * @author Kevin
 */
class Client {

    public static void main(String[] args) {
        BinaryTree tree = new BinaryTree();

        tree.insert(new Node(10));
        tree.insert(new Node(31));
        tree.insert(new Node(32));

    }
}
