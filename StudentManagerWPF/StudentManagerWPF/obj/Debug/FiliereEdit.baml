   M S B A M L   `   `   `  ����L  HStudentManagerWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:StudentManagerWPFStudentManagerWPF  5   	   #    StudentManagerWPF.FiliereEdit   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:StudentManagerWPF     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962af bMaterialDesignThemes.MahApps, Version=0.1.5.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5        � Icon$  Assets/icone.png��5       � Title$ FiliereEdit��5   	   $	��300��6   $
��600 ��6+    � 
ResizeMode$ NoResize=�68    � WindowStartupLocation$ CenterScreen=�6N    � WindowStyle$
 None=�6s   .��5      � .+�5   
   � $��20��6   ���#2fb7eb$	��Top=�60   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Right=�62   .+�5      �� -   5        $��Assets/shut.png��5      $��2q�6N   5      5      � 5   
   .+�5      �� $ 
Horizontal=�6   $��50q�62   .+�5      �� -   5        $��FilId��5      $��Filière Id : ��6%      MaterialDesignLabel#��[  6=   $
��Bold"�6k   �� 5      -   5         ��Name$ TextId��5      #��[  6)   
���  ��6V   5      �� 5      $ Vertical=�6   $��Center=�61   $	��Top=�6N   $
��0 80q�6f   .+�5      �� -   5         ��Name$ TextName��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$! Entez le Nom de la filière��6.    % !MaterialDesignFloatingHintTextBox#��[ 6j   $	��458��6�   $��Center=�6�   $��0 0 0 15q�6�   �� 5      -   5        $	��msg��5      
���  ��6#   �� 5      -   5        $ 	TextRespo��5      $" Entrez le nom du Responsable��6/   #��[ 6m   $	��458��6�   $��Center=�6�   5      �� 5       $ 
Horizontal=�6   $��Center=�63   $��80��6P   $��Bottom=�6\   $��158,0,162,-1q�6w   .+�5"      �� -   5        $��modifier��5"   -   $��Modifier��6   ���	#FF65C765$��30��6T   $��80��6`   $
��Bold"�6k   
�������$��	 0 0 20 2q�6�   $��5q�6�   ���	#FF65C7656�   �� 5$      -   5        $��	supprimer��5$   .   $��	Supprimer��6   ���	#FFE66262$��30��6V   $��80��6b   $
��Bold"�6m   
�������$��10 0 0 2q�6�   $��5q�6�   ���	#FFE662626�   5&      �� 5'      -	   5        $��ajouter��5'   (   $��Ajouter��6   ���	#FF4A78DA$��30��6N   $��80��6Z   $
��Bold"�6e   
�������$��258,211,262,59q�6�   $��5q�6�   	 J� RenderTransformOrigin$	 0.547,1.513&�6�   6�   5)      � 5*   
   $��20��6   ���#2fb7eb$��Bottom=�60   5-      5/      