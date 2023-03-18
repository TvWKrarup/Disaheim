﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class CourseRepository : Utility
    {
        // Attributes
        private List<Course> courses;

        // Methods

        // Tilføjer et kursus til vores liste "_courses".
        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        // Hvis kursus eksisterer med et navn returneres navn (er lidt i tvivl om det er navn eller selve kurset der skal returneres
        // for nuværende.
        public Course GetCourse(string name)
        {
            foreach (Course course in courses)
            {
                if (course.Name == name)
                    return course;
            }
            return null;
        }

        // Alle kursers værdi samles i "total" og returneres når metoden kaldes.
        public double GetTotalValue()
        {
            foreach (Course course in courses)
            {
                double total =+ GetValueOfCourse(course);
                return total;
            }
            return 0;
        }
    }
}