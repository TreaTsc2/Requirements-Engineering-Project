 

DROP TABLE FoodIntake;
DROP TABLE FoodItems;
DROP TABLE Accounts;
DROP TABLE MealType;
DROP TABLE ItemStatus;
DROP TABLE ActivityLevel;

CREATE TABLE ActivityLevel (
    ActivityLevelID NUMERIC(1),
    LevelName VARCHAR2(17),
    LevelCoefficient DECIMAL(3,2),
    
    CONSTRAINT pk_ActivityLevelID PRIMARY KEY(ActivityLevelID)
);

CREATE TABLE Accounts (
    UserID NUMERIC(3) NOT NULL,
    Surname VARCHAR2(15) NOT NULL,
    Forename VARCHAR2(15) NOT NULL,
    Email VARCHAR2(30) NOT NULL,
    Password VARCHAR2(16) NOT NULL, 
    DOB DATE NOT NULL,
    Height NUMERIC(3) NOT NULL,
    Weight NUMERIC(4,1) NOT NULL,
    Gender VARCHAR2(6) NOT NULL,
    ActivityLevelID NUMERIC(1) NOT NULL,
    DailyCalorieGoal NUMERIC(8) NOT NULL,
    
    CONSTRAINT pk_UserID PRIMARY KEY(UserID),
    CONSTRAINT fk_Accounts_ActivityLevelID FOREIGN KEY(ActivityLevelID) REFERENCES ActivityLevel(ActivityLevelID)
);

CREATE TABLE MealType (
    MealTypeID NUMERIC(1) NOT NULL,
    MealTypeName VARCHAR2(10) NOT NULL,
    
    CONSTRAINT pk_MealtypeID PRIMARY KEY(MealTypeID)
);

CREATE TABLE ItemStatus (
    ItemStatusID NUMERIC(1) NOT NULL,
    StatusName VARCHAR2(10) NOT NULL,
    
    CONSTRAINT pk_ItemStatusID PRIMARY KEY(ItemStatusID)
);

CREATE TABLE FoodItems (
    FoodItemID NUMERIC(8) NOT NULL,
    FoodName VARCHAR2(30) NOT NULL,
    Portion VARCHAR2(20) NOT NULL,
    CaloriesPerUnit NUMERIC(4) NOT NULL,
    UserID NUMERIC(3),
    ItemStatusID NUMERIC(1) NOT NULL,
    
    CONSTRAINT pk_FoodItemID PRIMARY KEY(FoodItemID),
    CONSTRAINT fk_FoodItems_UserID FOREIGN KEY(UserID) REFERENCES Accounts(UserID),
    CONSTRAINT fk_FoodItems_ItemStatusID FOREIGN KEY(ItemStatusID) REFERENCES ItemStatus(ItemStatusID)
);

CREATE TABLE FoodIntake (
    IntakeID NUMERIC(8) NOT NULL,
    IntakeDate DATE NOT NULL,
    MealTypeID NUMERIC(1) NOT NULL,
    PortionSize DECIMAL (3,1) NOT NULL,
    UserID NUMERIC(3) NOT NULL,
    FoodItemID NUMERIC(8) NOT NULL,
    Calories NUMERIC(4) NOT NULL,

    CONSTRAINT pk_IntakeID PRIMARY KEY(IntakeID),
    CONSTRAINT fk_FoodIntake_UserID FOREIGN KEY(UserID) REFERENCES Accounts(UserID),
    CONSTRAINT fk_FoodIntake_FoodItemID FOREIGN KEY(FoodItemID) REFERENCES FoodItems(FoodItemID),
    CONSTRAINT fk_FoodIntake_MealTypeID FOREIGN KEY(MealTypeID) REFERENCES MealType(MealTypeID)
);

--Values for ItemStatus 
INSERT INTO ItemStatus
VALUES(1,'Active');
INSERT INTO ItemStatus
VALUES(2,'Removed');
INSERT INTO ItemStatus
VALUES(3,'Default'); --For Default Food Items available for all users

--Values for Activity Levels
INSERT INTO ActivityLevel
VALUES (1, 'Sedentary', 1.2);
INSERT INTO ActivityLevel
VALUES (2, 'Lightly Active', 1.37);
INSERT INTO ActivityLevel
VALUES (3, 'Moderately Active', 1.55);
INSERT INTO ActivityLevel
VALUES (4, 'Very Active', 1.72);
INSERT INTO ActivityLevel
VALUES (5, 'Extra Active', 1.9);

--Values for MealTypes
INSERT INTO MealType
VALUES (1, 'Breakfast');
INSERT INTO MealType
VALUES (2, 'Lunch');
INSERT INTO MealType
VALUES (3, 'Dinner');
INSERT INTO MealType
VALUES (4, 'Snack');

--Values for default Food Items(available to all users)
INSERT INTO FoodItems (FoodItemID, FoodName, Portion, CaloriesPerUnit, UserID,  ItemStatusID)
VALUES (1, 'White bread', '1 slice', 32, null, 3);
INSERT INTO FoodItems (FoodItemID, FoodName, Portion, CaloriesPerUnit, UserID, ItemStatusID)
VALUES (2, 'Medium Red Apple', 'Whole apple', 80, null, 3);
INSERT INTO FoodItems (FoodItemID, FoodName, Portion, CaloriesPerUnit, UserID,  ItemStatusID)
VALUES (3, 'Medium Banana', 'Whole banana', 89, null, 3);
INSERT INTO FoodItems (FoodItemID, FoodName, Portion, CaloriesPerUnit, UserID,  ItemStatusID)
VALUES (4, 'Low Fat Milk', '250ml', 75, null, 3);
INSERT INTO FoodItems (FoodItemID, FoodName, Portion, CaloriesPerUnit, UserID,  ItemStatusID)
VALUES (5, 'Sirloin Steak', '100g', 271, null, 3);
INSERT INTO FoodItems (FoodItemID, FoodName, Portion, CaloriesPerUnit, UserID,  ItemStatusID)
VALUES (6, 'Cottage Cheese', '100g', 205, null, 3);
INSERT INTO FoodItems (FoodItemID, FoodName, Portion, CaloriesPerUnit, UserID,  ItemStatusID)
VALUES (7, 'Hummus', '100g', 166, null, 3);
