/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package hw2javaproject;

import java.io.File;
import java.io.FileWriter;
import java.io.IOException;

/**
 * class that implements a dummy database software
 * 
 * A client can switch between different storage tools
 * using the setStorageStrategy method
 * 
 * The data will be written to the same file, regardless
 * of what storage tool is chosen
 * 
 * @author natha
 */
public class DatabaseSoftware {
    
    // instance of database tool interface
    private IDatabaseTool tool;
    // output file name
    String file_name = "database-output.out";
    
    /**
     * constructor for DatabaseSoftware object
     * default database tool is set to relational
     */
    DatabaseSoftware(){ 
        // create empty file
        createEmptyFile(file_name);

        // dummy output line
        System.out.println("Created Database Software object\nDefault tool is Relational");
        
        // instantiate tool with Relational constructor
        this.tool = new Relational();
    }
    
    /**
     * method to store the data using the current store strategy
     * @param data 
     */
    public void Store(String data){ tool.store(data, this.file_name); }
    
    /**
     * method to set a new store strategy
     * @param temp 
     */
    public void setStoreStrategy(IDatabaseTool temp){ this.tool = temp; }
    
    /**
     * method to create an empty output file
     * @param file_name 
     */
    private void createEmptyFile(String file_name){
        File file = new File(file_name);
        try{
            FileWriter fw = new FileWriter(file);
            fw.write("");
            fw.close();
        }
        catch (IOException e){ System.err.println("IO error"); }
    }
    
}
