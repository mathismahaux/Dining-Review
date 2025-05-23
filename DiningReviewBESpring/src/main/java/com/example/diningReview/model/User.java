package com.example.diningReview.model;

import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.Table;
import lombok.Data;

@Data
@Entity
@Table(name = "users")
public class User {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    private String displayName;
    private String city;
    private String state;
    private String zipcode;

    private Boolean interestedInPeanutAllergy;
    private Boolean interestedInEggAllergy;
    private Boolean interestedInDairyAllergy;
}