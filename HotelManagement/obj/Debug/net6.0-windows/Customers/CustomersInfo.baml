   M S B A M L   `   `   `  ????J  FHotelManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:HotelManagement.CustomersHotelManagement.Customers  5   	   -    'HotelManagement.Customers.CustomersInfo   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:HotelManagement.Customers     5   	     ? Title$  CustomersInfo??5   	    ? 
ResizeMode$ NoResize=?6    $	??500??66   $	??800??6C   .??5	      ? .+?5
   
   ]? .+?5      o? $	??Top=?6   .@?5      m? $??_File??6   .@?5      m? $
??_New??6   m? 5      $??_Open??6   m? 5      $??_Save??6   ?? 5      m? 5      -   5        $??_Exit??5      6.   5      5      ?? 5       ?? AcceptsReturn$
 True??6   $	??Top=?6+   $	??466??6@   5      ?? 5   
   -   5        $??Головна??5      $??0,16,651,412q?6#   ???	#FFFFFEC6???	#FF452E2E???	#FFF4FFD0 J? RenderTransformOrigin$ 0.5,0.5&?6?   z?5      V? 5      .~?5      ?? ?? 5       ?? AngleY$ 0.221Q?6$   ?? 5      T? 5       T? Y$ 0.263Q?6)   5       5"      ?? 5#   
   -   5        $??Кімнати??5#      $??133,17,491,412q?6#   ???	#FFFFFEC6???	#FF452E2E
???????6}   ?? 5$   
   -   5        $??Користувачі??5$      $??264,17,307,412q?6'   ???	#FFFFFEC6???	#FF452E2E
???????6?   ?? 5%   
   -   5        $??Резервація??5%      $??426,17,189,412q?6&   ???	#FFFFFEC6???	#FF452E2E
???????6?   ?? 5&   
   -   5         ??Name$ customerOption??5&      $??329,109,276,333q?6+   .@?5'      ?? .??6   '%Найдовше проживання60   ?? 5(      .??6   ,*Кількість бронювань (>2)65   ?? 5)       ?? 
IsSelected$
 True??6   .??6-   Показати всіх6<   5*      ?? 5+   
   $Y??SПоказати користувачів за вказаним критерієм:??6   $??54,105,400,311q?6G   &   System.Windows.Controls.DataGrid  5,   
   -   5          Name$ listOfCustomers??5,   c   $??0??6   $??1??6    	   AutoGenerateColumns$	 False??60   
   CanUserAddRows$
 False??6L   $??64,200,40,42q?6|   $??3??6?    ? ContextMenu 5-      ?? 5.      -   5        $??cm??5.      .@?5/      m? -	   5        $
??Open??5/      6-   m? 50      -
   5        $
??Save??50      6-   m? 51      -   5        $??SaveAs??51      6/   52         Columns 54      0  *System.Windows.Controls.DataGridTextColumn  55      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name??6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 120 63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   ?? *Name+  56      $ Lastname??6%   $	 120 67    6C   ?? *
Lastname+  57      $	 Age??6%   $ 70 62    6=   ?? *Age+  58      $ Phone??6%   $	 100 64    6@   ?? *Phone+  59      $ Email??6%   $	 100 64    6@   ?? *Email+  5:      $
 Room??6%   $ 90 63    6>   ?? *Room+5<      ?? 5=   
   -   5         ??Name$ apply??5=      $??Застосувати??6    $??543,105,121,333q?66   ???	#FFFFFEC6???	#FF452E2E
???????6?   ?? 5>   
   $?? ??6   $??558,17,0,412q?6   ???	#FFFFFEC6???	#FF452E2E
???????6`   5?      5@      