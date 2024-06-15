
---User
--DROP TABLE [User]
--SELECT * FROM [User]
INSERT INTO [User] (Username, Password) VALUES 
('john_doe', 'password123'),
('jane_smith', 'password456'),
('Judson.Murray', '12345');
GO

---Workout
--DELETE FROM Workout
--DROP TABLE Workout
--SELECT * FROM Workout
INSERT INTO Workout (UserID, WorkoutTitle) VALUES 
(1, 'Morning Workout'),
(1, 'Evening Workout'),
(2, 'Cardio Routine'),
(3, 'Leg Workout'),
(2, 'Shoulders Workout'),
(3, 'Triceps Routine')
GO

---Exercise
--DELETE FROM Exercise
INSERT INTO Exercise (ExerciseTitle, ExerciseDescription, ExerciseInstructions) VALUES 
('Push Up', 'A push up is a common exercise.', 'Keep your body straight and lower yourself until your chest nearly touches the floor.'),
('Squat', 'A squat is a strength exercise.', 'Stand with feet a little wider than hip width, toes facing front.'),
('Lunge', 'A lunge is a single-leg bodyweight exercise.', 'Step forward with one leg, lowering your hips until both knees are bent at about a 90-degree angle.'),
('Triceps Press', 'A triceps press targets the triceps.', 'Press the weight upward until your arms are fully extended.'),
('Biceps Curl', 'A biceps curl targets the biceps.', 'Lift the weight until your forearm is vertical and your biceps are fully contracted.');
GO

---WorkoutExercise
--DELETE FROM WorkoutExercise
--SELECT * FROM WorkoutExercise
INSERT INTO WorkoutExercise (WorkoutID, ExerciseID, ExerciseWeight, ExerciseSets, ExercisesReps) VALUES 
(1, 1, 25, 3, 15),
(1, 2, 45, 3, 12),
(2, 3, 15, 3, 10),
(3, 1, 150, 3, 15);
GO

--SELECT * FROM WorkoutExercise

---Muscle
--DELETE FROM Muscle
--SELECT * FROM Muscle
INSERT INTO Muscle (MuscleTitle) VALUES 
('Chest'),
('Legs'),
('Arms'),
('Shoulders'),
('Glutes');
GO


---ExerciseMuscle
--SELECT * FROM ExerciseMuscle
----DELETE FROM ExerciseMuscle
INSERT INTO ExerciseMuscle (ExerciseID, MuscleID) VALUES 
(1, 1),
(2, 2),
(3, 2),
(1, 3);


----------