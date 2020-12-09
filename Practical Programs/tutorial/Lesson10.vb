'@desc: 10 : Putting It Altogether

'================================================================
'Author: Anoop - anoop@logicmatrixonline.com 
'        http://www.logicmatrixonline.com/anoop
'================================================================


'Note: To compile this file, use the command
'vbc Lesson10.vb /r:"System.Windows.Forms.dll","System.dll"
'================================================================

'LESSON 10: PUTTING IT ALTOGETHER
'----------------------------------------------------

'Let us analyze a simple program.


'Importing required namespaces
Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Drawing

'----------------------------------------------------

	'We are inheriting a class named SimpleForm, from the
	'class System.Windows.Forms.Form
	'
	'i.e, Windows is a namespace in system, Forms is a
	'namespace in Windows, and Form is a class in Forms.
	
    Public Class SimpleForm
        Inherits System.Windows.Forms.Form

		'Our constructor
        Public Sub New()
        	'This will invoke the constructor of the base
        	'class
            MyBase.New()
            
            'Set the text property of this class. We inherited
            'this property from the base class.
            
            Me.Text = "Hello, How Are You?"
            
        End Sub
    End Class

'----------------------------------------------------

    
    Public Class MainClass
    
    	Shared Sub Main()
    		'Create an object from our SimpleForm class
    		Dim sf as SimpleForm
    		sf=new SimpleForm
    		
    		'Pass this object to the Run() function to start
    		 System.Windows.Forms.Application.Run(sf)
    	End Sub
    
    End Class


