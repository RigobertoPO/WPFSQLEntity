   M S B A M L   `   `   `  ����K  GWPFSQLEntity.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:WPFSQLEntity.WPF.ContactosWPFSQLEntity.WPF.Contactos  5   	   !    WPFSQLEntity.WPF.MainWindow   6	Contactos(clr-namespace:WPFSQLEntity.WPF.Contactos  \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��600��6   $	��800��6)   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��10* �6   �� 5      $��40 �6   �� 5	      $	��10* �6   ��5   
   �� 5         FondoColorPrincipal �� Color# �   6   .+�5   
   �� $��0��6   $��	10,20,5,5q�6!   
�������$��3q�6H    �� CornerRadius$ 	10,0,0,25��6\   ��5      �� 5        Fondocentral# �  6"   ._�5      ,   &WPFSQLEntity.WPF.Contactos.ContactosUC  -   5          Name$ listadoContactos��5   $   ,   &WPFSQLEntity.WPF.Contactos.ContactosUC   NuevoContacto$ ListadoContactos_Click��6>      Seleccionado$% listadoContactos_Seleccionado_1��6e      Editar$ listadoContactos_Editar_1��6�   5      � 5   
   $��1��6   .+�5      �� $��40��6   $	��600��6    .+�5      �� $��40��6   $	��603��6'    �� Left$ 0.972534��64   
	 �� Top$	 0��6K   
 �� Stretch$

 Fill=�6Z   ���	#FF04272D6i   �� 5      $��40��6   $��18.677��6(   $ 0.311768��68   $	 60.0327��6O   $

 Fill=�6d   ���	#FFCBD8DA6s   �� 5      $��40��6   $��18.677��6'   $ 0.571167��67   $	 87.1595��6N   $

 Fill=�6c   ���	#FFCBD8DA6r   �� 5      $��40��6   $��18.677��6'   $ 0.571167��67   $	 246.367��6N   $

 Fill=�6c   ���	#FFCBD8DA6r   �� 5      $��40��6   $��18.6769��6(   $ 0.131104��69   $	 277.163��6P   $

 Fill=�6e   ���	#FFCBD8DA6t   �� 5      $��40��6   $��18.677��6(   $ 0��68   $	 526.869��6H   $

 Fill=�6]   ���	#FFCBD8DA6l   �� 5      $��40��6   $��18.677��6(   $ 0.260986��68   $	 553.996��6O   $

 Fill=�6d   ���	#FFCBD8DA6s   5      5      �� 5   
   $��2��6   $��	5,20,10,5q�6!   
�������$��3q�6I   $ 	0,10,25,0��6]   ��5       �� 5!      # �  6"   ._�5#      � -   5        $��DetalleGrid��5#      5%      5&      5'      5(      