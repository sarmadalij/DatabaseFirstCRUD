﻿using System;
using System.Collections.Generic;

namespace DatabaseFirstCRUD.Models;

public partial class Student
{
    public int Id { get; set; }

    public string StudentName { get; set; } = null!;

    public string StudentGender { get; set; } = null!;

    public int Age { get; set; }

    public string StudentDepartment { get; set; } = null!;
}
