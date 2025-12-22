USE rental;

CREATE TABLE DamageReport (
    DamageReportId INT AUTO_INCREMENT PRIMARY KEY,
    VehicleId INT NOT NULL,
    ReportDate DATE,
    Description TEXT,
    EstimatedCost DECIMAL(10,2),
    FOREIGN KEY (VehicleId) REFERENCES Vehicle(VehicleId)
);
CREATE TABLE RateConfiguration (
    RateId INT AUTO_INCREMENT PRIMARY KEY,
    VehicleType ENUM('SUV','Sedan','Hatchback','Pickup'),
    DailyRate DECIMAL(10,2),
    EffectiveFrom DATE,
    EffectiveTo DATE
);
CREATE TABLE License (
    LicenseId INT AUTO_INCREMENT PRIMARY KEY,
    CustomerId INT NOT NULL,
    LicenseNumber VARCHAR(50),
    ExpiryDate DATE,
    FOREIGN KEY (CustomerId) REFERENCES Customer(CustomerId)
);