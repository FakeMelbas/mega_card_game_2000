   M S B A M L   `   `   `  ����N  JMega card game 2000, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Mega_card_game_2000Mega_card_game_2000  5           Mega_card_game_2000.Battle   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:Mega_card_game_2000     5        N� Title$  RPG Cards - Battle��5	      $	��475��6"   $	��450��6/    N� 
Background
 �Gc��$��5q�6O   .��5
      �� $��20q�6   
�������._�5      �  � ColumnDefinitions 5   
   �� 5       � RowDefinitions 5   
   �� 5      �� 5      .+�5   
   �� -   5         ��Name$ BattleNames��5      $	��Top=�6%   $��Center=�6=   
�������$��Player Versus '  '��6v   � 5   
   $��25q�6    5      �� 5      �� 5      .+�5      �� $��Center=�6   $��Center=�66   .+�5      �� -   5         ��Name$ playerHP��5      $��Health: ��6.   $	��Top=�6>   $��Center=�6V   
�������$��50��6�   �� 5      -   5        $ 	playerDMG��5      $��Damage: ��6/   $��Center=�6?   $��Center=�6Z   
�������$��50��6�   �� 5      -   5         ��Name$ normalAttack��5      
�������
���   �$	��100��6y   $��Bottom=�6�   $
��Left=�6�   $��Normal Attack��6�   5      �� 5      $��1��6   $��Center=�6)   $��Center=�6D   .+�5      �� -   5        $ enemyHP��5      $��Health: ��6-   
�������$	��Top=�6Y   $��Center=�6q   $��50��6�   �� 5       -   5        $ enemyDMG��5       $��Damage: ��6.   
�������$��Center=�6Z   $��Center=�6u   $��50��6�   �� 5!      -   5        $ specialAttack��5!      
�������
���   �$	��100��6{   $��Bottom=�6�   $
��Left=�6�   .��6�   Special Attack6�   5#      5$      � 5&   
   $��0��6   $��1��6   $��20q�6,    5'      �� 5(       5*      �� 5+      �� 5,      $	��280 �6    .+�5.      �� $��1��6   $��15q�6&   .+�5/      �� -   5        $ BattleLogLabel��5/      $��BATTLE LOG:��60   
�������6F   �� 50      -	   5         ��Name$ 	BattleLog��50      $	��150��6-   $	��300��6:   $��Bottom=�6F   $��Center=�6a   52      53      54      55      57      