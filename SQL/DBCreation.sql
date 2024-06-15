


--DROP DATABASE GymManager
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'GymManager')
BEGIN
    CREATE DATABASE GymManager;
END;
GO

USE GymManager;
GO

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'User')
BEGIN
    CREATE TABLE [User] (
        UserID INT IDENTITY(1,1) NOT NULL,
        Username VARCHAR(50) NOT NULL UNIQUE,
        Password VARCHAR(255) NOT NULL,
        CONSTRAINT PK_UserID PRIMARY KEY (UserID)
    );
END;
GO

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Workout')
BEGIN
    CREATE TABLE Workout (
        WorkoutID INT IDENTITY(1,1) NOT NULL,
        UserID INT NOT NULL,
        WorkoutTitle VARCHAR(255) NOT NULL,
        CONSTRAINT PK_WorkoutID PRIMARY KEY (WorkoutID),
        CONSTRAINT FK_Workout_UserID FOREIGN KEY (UserID) REFERENCES [User](UserID) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Exercise')
BEGIN
    CREATE TABLE Exercise (
        ExerciseID INT IDENTITY(1,1) NOT NULL,
        ExerciseTitle VARCHAR(255) NOT NULL,
        ExerciseDescription TEXT,
        ExerciseInstructions TEXT,
        CONSTRAINT PK_ExerciseID PRIMARY KEY (ExerciseID)
    );
END;
GO

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'WorkoutExercise')
BEGIN
    CREATE TABLE WorkoutExercise (
        WorkoutDetailsID INT IDENTITY(1,1) NOT NULL,
        WorkoutID INT NOT NULL,
        ExerciseID INT NOT NULL,
        ExerciseWeight DECIMAL(5, 2),
        ExerciseSets INT,
        ExercisesReps INT,
        CONSTRAINT PK_WorkoutDetailsID PRIMARY KEY (WorkoutDetailsID),
        CONSTRAINT FK_WorkoutExercise_WorkoutID FOREIGN KEY (WorkoutID) REFERENCES Workout(WorkoutID) ON DELETE CASCADE,
        CONSTRAINT FK_WorkoutExercise_ExerciseID FOREIGN KEY (ExerciseID) REFERENCES Exercise(ExerciseID) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Muscle')
BEGIN
    CREATE TABLE Muscle (
        MuscleID INT IDENTITY(1,1) NOT NULL,
        MuscleTitle VARCHAR(100) NOT NULL,
        CONSTRAINT PK_MuscleID PRIMARY KEY (MuscleID)
    );
END;
GO

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'ExerciseMuscle')
BEGIN
    CREATE TABLE ExerciseMuscle (
        ExerciseMuscleID INT IDENTITY(1,1) NOT NULL,
        ExerciseID INT NOT NULL,
        MuscleID INT NOT NULL,
        CONSTRAINT PK_ExerciseMuscleID PRIMARY KEY (ExerciseMuscleID),
        CONSTRAINT FK_ExerciseMuscle_ExerciseID FOREIGN KEY (ExerciseID) REFERENCES Exercise(ExerciseID) ON DELETE CASCADE,
        CONSTRAINT FK_ExerciseMuscle_MuscleID FOREIGN KEY (MuscleID) REFERENCES Muscle(MuscleID) ON DELETE CASCADE
    );
END;
GO








