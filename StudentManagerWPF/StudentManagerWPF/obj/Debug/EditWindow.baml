   M S B A M L   `   `   `  ����L  HStudentManagerWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:StudentManagerWPFStudentManagerWPF  5   	   "    StudentManagerWPF.EditWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:StudentManagerWPF     5   	   -   5          � Icon$  Assets/icone.png��5       � Title$ 
EditWindow��5
   	   $	��550��6   $
��1000��6)    � 
ResizeMode$ NoResize=�66    � WindowStartupLocation$ CenterScreen=�6L    � WindowStyle$
 None=�6q   .��5      � .+�5   
   � $��20��6   
�������$	��Top=�63   .+�5      �� -   5        $��Assets/back.png��5      $
��Left=�6-   6I   �� 5       �� Orientation$ 
Horizontal=�6   $��Right=�62   .+�5      �� -   5        $��Assets/shut.png��5      $��2q�6N   5      5      � 5   
   $	��530��6   $��Bottom=�6   .+�5      �� $	��960��6   $	��500��6%   $
��15 0q�63    �� RadiusY$ 12��6A    �� RadiusX$ 12��6N   
�������$��Center=�6h    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      	   Color$	 	#FFC1D3E4��6'   
   	Direction$
 0Q�69      
BlurRadius$ 10Q�6G      RenderingBias$ Quality=�6W      ShadowDepth$ 1Q�6o   5      � 5      $	��960��6   $	��500��6   $
��15 0q�6-   $��Center=�6;   .+�5      �� .+�5      �  � Orientation$ 
Horizontal=�6    $��Center=�69   $��15q�6V   .+�5      �� -   5        $��
Button1ere��5   >   $��0,0,5,0q�6!   $	��130��62   ���#2000ff.��6   1ére Année6�   �� 5      -   5        $��
Button2eme��5   S   $��0,0,5,0q�6!   $	��130��62   ���#72a7da.��6~   2éme Année6�   �� 5      -   5        $��
Button3eme��5   S   $��0,0,5,0q�6!   $	��130��62   ���#72a7da.��6~   3éme Anée6�   �� 5      -   5        $��
addStudent��5   K   $��	130,0,5,0q�6!   $��60��64   $��35��6?   ���	#FF154F7E��6]   Z� .��5      �� $��/Assets/student.png��6$   $��30��6A   $��40��6L   6Z   5       5!      � 5#      -   5         �Name$ cards��5#   =   $��0��6    $��2��6-   $��10q�6L   5%      5&      5(      5)      5*      