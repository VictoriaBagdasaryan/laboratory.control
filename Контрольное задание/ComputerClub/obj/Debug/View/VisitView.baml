   M S B A M L   `   `   `  ????G  CComputerClub, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ComputerClub.ViewComputerClub.View  5   	   !    ComputerClub.View.VisitView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ComputerClub.View     5   	     ? Title$  Посещение??5   	   $	??450??6   $	??450??6(   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6    ? ColumnDefinitions 5   
   ?? 5      6!   ?? 5      6!   ?? 5      6!   ?? 5      6!   .+?5   
   ?? $??Center=?6   $??0??6+   $??0??68   .??6H   ID посещения6V   ?? 5   
   -   5         ??Name$ VisitIDTextBox??5      $??Center=?6C   $??0??6^   $??1??6k   $??3??6{   $??40??6?    ?? 
IsReadOnly . ??6*   ?? *	VisitID+6?   ?? 5   
   $??Center=?6   $??1??6+   $??0??68   .??6H   Посетитель6T   ?? 5   
   -   5         ??Name$ VisitorIDTextBox??5       ?? DisplayMemberPath$ SurName??6-   $??Center=?6J   $??1??6e   $??1??6r   $??3??6?   $??40??6?   6?   ?? 5!   
   $??Center=?6   $??2??6+   $??0??68   .??6H   Компьютер6S   ?? 5"   
   -   5        $ ComputerIDTextBox??5"      $ ComputerName??6.   $??Center=?6P   $??2??6k   $??1??6x   $??3??6?   $??40??6?   6?   ?? 5$   
   $??Center=?6   $??3??6+   $??0??68   .??6H   
Дата6N   ?? 5%   
   -   5        $ VisitDateTextBox??5%      $??Center=?6G   $??3??6b   $??1??6o   $??3??6   $??40??6?   ??6,   ?? *	VisitDate+6?   ?? 5'   
   $??Center=?6   $??4??6+   $??0??68   .??6H   Длительность6V   ?? 5(   
   -   5        $ VisitLenghtTextBox??5(      $??Center=?6K   $??4??6f   $??1??6s   $??3??6?   $??40??6?   ??6.   ?? *VisitLenght+6?   ?? 5*   
   $??Center=?6   $??5??6+   $??0??68   .??6H   
Плата6O   ?? 5+   
   -   5        $ 
PayTextBox??5+      $??Center=?6;   $??5??6V   $??1??6c   $??3??6s   $??40??6?   ??6&   ?? *Pay+6?   ?? 5-   
   -   5         ??Name$ OKButton??5-      $??1??6#   $??8??63   $??25??6@   $	??100??6L   .??6o   ОК6s   ?? 5.   
   -   5        $ CancelButton??5.      $??2??6'   $??8??67   $??25??6D   $	??100??6P   .??6w   Отмена6   5/      50      