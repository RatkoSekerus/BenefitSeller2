-- Drop existing tables if they exist
DROP TABLE IF EXISTS CompanyBenefit;
DROP TABLE IF EXISTS Transactions;
DROP TABLE IF EXISTS Users;
DROP TABLE IF EXISTS SubscriptionPlans;
DROP TABLE IF EXISTS Merchants;
DROP TABLE IF EXISTS MerchantCategories;
DROP TABLE IF EXISTS MerchantCategoryGroups;
DROP TABLE IF EXISTS Companies;
DROP TABLE IF EXISTS Company;
DROP TABLE IF EXISTS Merchant;
DROP TABLE IF EXISTS SubscriptionPlan;
DROP TABLE IF EXISTS MerchantCategory;

DROP TABLE IF EXISTS MerchantCategoryGroup;


-- Create tables
CREATE TABLE company (
    id SERIAL PRIMARY KEY,
    name VARCHAR(255) NOT NULL
);

CREATE TABLE merchantcategorygroup (
    id SERIAL PRIMARY KEY,
    name VARCHAR(255) NOT NULL
);

CREATE TABLE merchantcategory (
    id SERIAL PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    merchantcategorygroupid INT NOT NULL,
    CONSTRAINT fk_merchantcategory_group FOREIGN KEY (merchantcategorygroupid) REFERENCES merchantcategorygroup (id)
);

CREATE TABLE merchant (
    id SERIAL PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    earnings DECIMAL(10, 2) DEFAULT 0,
    discountpercentage DECIMAL(5, 2) DEFAULT 0,
    merchantcategoryid INT NOT NULL,
    CONSTRAINT fk_merchant_category FOREIGN KEY (merchantcategoryid) REFERENCES merchantcategory (id)
);

CREATE TABLE subscriptionplan (
    id SERIAL PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    subscriptiontype SERIAL NOT NULL
);

CREATE TABLE users (
    id SERIAL PRIMARY KEY,
    username VARCHAR(255) NOT NULL,
    balance DECIMAL(10, 2) DEFAULT 100,
    subscriptionplanid INT NOT NULL,
    companyid INT NOT NULL,
    CONSTRAINT fk_user_subscription FOREIGN KEY (subscriptionplanid) REFERENCES subscriptionplan (id),
    CONSTRAINT fk_user_company FOREIGN KEY (companyid) REFERENCES company (id)
);

CREATE TABLE transactions (
    id SERIAL PRIMARY KEY,
    amount DECIMAL(10, 2) DEFAULT 10,
    transactiondate TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    transactionstatus INT NOT NULL,
    userid INT NOT NULL,
    merchantid INT NOT NULL,
    CONSTRAINT fk_transaction_user FOREIGN KEY (userid) REFERENCES users (id),
    CONSTRAINT fk_transaction_merchant FOREIGN KEY (merchantid) REFERENCES merchant (id)
);

CREATE TABLE companybenefit (
    companyid INT NOT NULL,
    merchantcategorygroupid INT NOT NULL,
    PRIMARY KEY (companyid, merchantcategorygroupid),
    CONSTRAINT fk_company FOREIGN KEY (companyid) REFERENCES company (id),
    CONSTRAINT fk_merchantcategorygroup FOREIGN KEY (merchantcategorygroupid) REFERENCES merchantcategorygroup (id)
);


-- Insert initial data
INSERT INTO company (name) VALUES ('TechCorp'), ('Healthify');

INSERT INTO merchantcategorygroup (name) VALUES ('Electronics'), ('Food & Beverages');

INSERT INTO merchantcategory (name, merchantcategorygroupid) VALUES 
('Smartphones', 1), 
('Fast Food', 2);

INSERT INTO merchant (name, earnings, discountpercentage, merchantcategoryid) VALUES 
('BestBuy', 5000.00, 10.00, 1), 
('McDonalds', 2000.00, 5.00, 2);

INSERT INTO subscriptionplan (name, subscriptiontype) VALUES 
('Basic Plan', 1), 
('Premium Plan', 1);

INSERT INTO users (username, balance, subscriptionplanid, companyid) VALUES 
('john_doe', 150.00, 1, 1), 
('jane_doe', 200.00, 2, 2);

INSERT INTO transactions (amount, transactiondate, transactionstatus, userid, merchantid) VALUES 
(50.00, '2024-12-01 10:00:00', 1, 1, 1), 
(20.00, '2024-12-02 14:00:00', 0, 2, 2);

INSERT INTO companybenefit (companyid, merchantcategorygroupid) 
VALUES 
(1, 1), -- TechCorp and Electronics
(1, 2); -- TechCorp and Food & Beverages
