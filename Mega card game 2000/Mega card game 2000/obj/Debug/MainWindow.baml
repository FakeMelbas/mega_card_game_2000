   M S B A M L   `   `   `  ����N  JMega card game 2000, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Mega_card_game_2000Mega_card_game_2000  5   	   $    Mega_card_game_2000.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Mega_card_game_2000     5   	     N� Title$  RPG Cards - Character��5   	    N� 
Background
 �Gc��.��5	      �� $��20q�6   
�������._�5
      � .+�5   
   � $��5q�6    � RowDefinitions 5      �� 5      �� 5      $��25 �6    �� 5      �� 5      $��50 �6     � ColumnDefinitions 5      �� 5      �� 5      �� 5      .+�5      �� -   5         ��Name$
 Name��5      $$��What is your name, adventurer?��6&   
�������$��Center=�6h   $��Center=�6�   �� 5      -   5         ��Name$ getName��5      $��0��6'   $��1��64   $��20��6D   $	��150��6P   $��Center=�6\   $��Center=�6y   �� 5      -   5        $ Details��5      $n��h You've been dealt three cards. 
 Choose your hand. 
 but know this, your fate
 has already been decided��6)   
�������$��0��6�   $��2��6�   �� 5       -   5         ��Name$ WarriorButton��5       
���   �$��3��6\   $��Center=�6i   $��25��6�   
���Gc��
�������$	��Top=�6�   .��6�   	WARRIOR6�   �� 5"      -   5        $ ThiefButton��5"      
���   �$��3��6X   $��1��6e   $��Center=�6u   $��25��6�   
���Gc��
�������$	��Top=�6�   .��6�   THIEF6�   �� 5#      -   5        $ 
MageButton��5#      
���   �$��3��6V   $��2��6c   $��Center=�6s   $��25��6�   
���Gc��
�������$	��Top=�6�   .��6�   MAGE6�   �� 5$      $��1��6   5&      �� 5'      $��2��6   .+�5(      �� -   5        $ WarriorDetails��5(       $��Center=�68   $��1��6U   
�������$��10q�6~   " Warrior's Berserk special attack�� 6�    has a 1 in 3 chance of dealing�� 6�   
30 damage.6�   �� 5)      -   5         ��Name$ Warrior��5)      $��Images/Warrior.jpg��6-   $	��100��6I   $��Center=�6V   5*      �� 5,      $��1��6   $��2��6)   .+�5-      �� -	   5        $ ThiefDetails��5-       $��Center=�66   $��1��6S   $��1��6`   
�������!Thief's Backstab special attack�� 6�    has a 1 in 3 chance of dealing�� 6�   20 damage, or only 5 damage�� 6  if it fails.6  �� 5.      -
   5        $ Thief��5.      $��Images/thief.jpg��6+   $	��105��6E   $	��150��6R   $��Center=�6^   5/      �� 51      $��2��6   $��2��6)   .+�52      �� -   5        $ MageDetails��52       $��1��65   $��Center=�6B   $��2��6_   
������� Mage's Fireball special attack�� 6�    has a 1 in 2 chance of dealing�� 6�    40 damage, or hurting themself�� 6  
for -10 HP6  �� 53      -   5        $
 Mage��53      $��Images/Mage.jpg��6*   $	��105��6C   $	��150��6P   $��Center=�6\   54      55      56      57      58      