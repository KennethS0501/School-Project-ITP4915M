# ITP4915M Assignment

## Topic
Make an SDLC document according to a Case study, and finally make a software coding with Windows Forms C#.

## Case Study Example
a. Place orders

    The sales representatives in retail stores receive sales orders from customers every day.
    If the item is available in-store, payment will be processed directly. 
    The payment receipt is currently handwritten, one copy for the store and the other for the customer. 
    If the requested item is unavailable, in-store or stock level at stock is close to or below re order level. 
    In that case, the sales manager will call Inventory Department at the warehouse and ask them to deliver a certain number of items to the store. 
    For unavailable items over $5000, the customer needs to pay 20% or more of the price as a deposit. 
    The payment will be completed later when stock is available. 
    Receipts of completed orders will be sent to Accounting Department on the first day of each month, 
    and deposit receipts are still kept in the deposit folder until the payment is completed.
    ... ...

b. Record of user interview

	Sale Department Computer printed receipts and in-store computerized system can improve the efficiency of the store and improve the store image.
    Staff have to login with password before using the system to ensure the system's security.
    As a new store will be opened in Pearl River Delta Region soon, both English and
    Simplified Chinese user interfaces are expected, especially for the functions used
    by the staff in the retail store.
    ... ...

Need to analyze the above information to do SDLC report and coding.

## The work i do: 
- Sales order
  - cancel order
  - handle defect item
  - check deposit
  - receipt

- Inventory & Sales depart
  - Restock control
    - confirm restock order
    - check Sales restock order

- IT department
  - Staff (All)
  - Account (All)
  - Data Access control

- Delivery service (All)
- Installation service (All)

- Login

- Database Design
- Setting database

## File structure
	WindowsFormsApp11
	|- Receipt (Save a receipt.pdf)
	|- WindowsFormsApp11
	| |- ITDepart
	| | |- Account
	| | | |- frmAccountManagement.cs (Backend)
	| | | |- frmAccountManagement.Designer.cs (Frontend)
	| | |- DataAccess
	| | |- Staff
	| |- InventoryDepart
	| |- LoginPage
	| |- SalesDepart
All the same

xxxx.cs is Backend

xxxx.Designer.cs is Frontend

## Demo Video
https://drive.google.com/file/d/1Kp2zUCSGSgA6sv0_eJ_vLK0XqlOL3MOh/view?usp=sharing

## Final Version

## Introduction
Submit Due date: 2022/6/27 4:30pm

The assignment project is ITP4915M of IT114105 of Hong Kong IVE(TY).
 
Study year: 2021/2022.

Number of team: 4

Programming language: C#

Tool is Visual Studio 2019.

Database: MySQL

Tool is MySQL Workbench.

## Prototype 1 
### Software Prototype: Basic Stage
Submit Due date: 2022/6/6 4:30pm

Information update time: 2022/6/6 4:20pm

*	[x] Menu Program / Login
*	[x] Sales Order Processing Management
    * [x] Create and Edit Sales Order
    * [x] View Sales Order
    *	[x] Generate receipt/ deposit
    *	[x] Search Sales Order
    *	[x] Payment (Full payment)
*	[x] Sales Order Processing Management
    * [x] Create and Edit Sales Order
    * [x] View Sales Order
    *	[x] Generate receipt/ deposit
    *	[x] Search Sales Order
    *	[x] Payment (Full payment)
* [x]	Delivery and installation Management
    *	[x] Arrange, Update and Track delivery service
    *	[x] Generate daily Delivery List
    *	[x] Setting of reorder/danger levels
*	[x] Master Data Maintenance (e.g. supplier, staff, product etc.)
*	[x] System Security & Control (e.g. password, data access control, etc.)
*	[x] Database Implementation

## Prototype 2
### Software Prototype: Basic Stage
Submit Due date: 2022/6/29 4:30pm

Information update time: 2022/6/24 9:42pm
* [x] Sales Order Processing Management
   * [x] Handle defect item
   * [x] Payment (Full payment/ with deposit)
* [x] Delivery and installation Management
   * [x] Arrange, Update and Track installation service
   * [x] Generate daily Installation List
* [x] Stock Recording / Warehouse Inventory Control
   * [x] Purchase goods
   * [x] Record of inward received goods
   
* [x] Exception

## Final grade
Grade: A
