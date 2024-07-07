using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RecipeClassLibrary;

public partial class HeartyHearthDbContext : DbContext
{
    public HeartyHearthDbContext()
    {
    }

    public HeartyHearthDbContext(DbContextOptions<HeartyHearthDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cookbook> Cookbooks { get; set; }

    public virtual DbSet<CookbookRecipe> CookbookRecipes { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<CuisineType> CuisineTypes { get; set; }

    public virtual DbSet<Ingredient> Ingredients { get; set; }

    public virtual DbSet<Meal> Meals { get; set; }

    public virtual DbSet<MealCourse> MealCourses { get; set; }

    public virtual DbSet<MealCourseRecipe> MealCourseRecipes { get; set; }

    public virtual DbSet<Measurement> Measurements { get; set; }

    public virtual DbSet<Recipe> Recipes { get; set; }

    public virtual DbSet<RecipeDirection> RecipeDirections { get; set; }

    public virtual DbSet<RecipeIngredient> RecipeIngredients { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=tcp:nrosenberg.database.windows.net,1433;Initial Catalog=HeartyHearthDB;Persist Security Info=False;User Id=nrosenberg;Password=Nissi@23;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cookbook>(entity =>
        {
            entity.HasKey(e => e.CookbookId).HasName("PK__Cookbook__7E5B352E07E07416");

            entity.ToTable("Cookbook");

            entity.HasIndex(e => e.CookbookName, "u_Cookbook_CookbookName").IsUnique();

            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CookbookName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CookbookPicture)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasComputedColumnSql("(concat('Cookbook-',translate([CookbookName],' ','-'),'.jpg'))", true);
            entity.Property(e => e.CookbookSkill).HasDefaultValue(1);
            entity.Property(e => e.CookbookSkillDesc)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasComputedColumnSql("(case when [CookbookSkill]=(1) then 'Beginner' when [CookbookSkill]=(2) then 'Intermediate' when [CookbookSkill]=(3) then 'Advanced'  end)", true);
            entity.Property(e => e.Price).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.UniqueCookbookId)
                .HasMaxLength(165)
                .IsUnicode(false)
                .HasComputedColumnSql("(concat([CookbookName],[Price],[CookbookSkill],[UserId]))", false);

            entity.HasOne(d => d.User).WithMany(p => p.Cookbooks)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("f_Users_Cookbook");
        });

        modelBuilder.Entity<CookbookRecipe>(entity =>
        {
            entity.HasKey(e => e.CookbookRecipeId).HasName("PK__Cookbook__1076C059C336A642");

            entity.ToTable("CookbookRecipe");

            entity.HasIndex(e => new { e.CookbookId, e.RecipeId }, "u_CookbookRecipe_CookbookId_RecipeId").IsUnique();

            entity.HasIndex(e => new { e.CookbookId, e.RecipeSequence }, "u_CookbookRecipe_CookbookId_RecipeSequence").IsUnique();

            entity.HasOne(d => d.Cookbook).WithMany(p => p.CookbookRecipes)
                .HasForeignKey(d => d.CookbookId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("f_Cookbook_CookbookRecipe");

            entity.HasOne(d => d.Recipe).WithMany(p => p.CookbookRecipes)
                .HasForeignKey(d => d.RecipeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("f_Recipe_CookbookRecipe");
        });

        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.CourseId).HasName("PK__Course__C92D71A7544BB183");

            entity.ToTable("Course");

            entity.HasIndex(e => e.CourseName, "u_Course_CourseName").IsUnique();

            entity.HasIndex(e => e.CourseSequence, "u_Course_CourseSequence").IsUnique();

            entity.Property(e => e.CourseName)
                .HasMaxLength(75)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CuisineType>(entity =>
        {
            entity.HasKey(e => e.CuisineTypeId).HasName("PK__CuisineT__C72F206F68E35F63");

            entity.ToTable("CuisineType");

            entity.HasIndex(e => e.CuisineTypeName, "u_CuisineType_CuisineTypeName").IsUnique();

            entity.Property(e => e.CuisineTypeName)
                .HasMaxLength(35)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Ingredient>(entity =>
        {
            entity.HasKey(e => e.IngredientId).HasName("PK__Ingredie__BEAEB25AE731E73B");

            entity.ToTable("Ingredient");

            entity.HasIndex(e => e.IngredientName, "u_Ingredient_IngredientName").IsUnique();

            entity.Property(e => e.IngredientName)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.IngredientPicture)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasComputedColumnSql("(concat('Ingredient-',translate([IngredientName],' ','-'),'.jpg'))", true);
        });

        modelBuilder.Entity<Meal>(entity =>
        {
            entity.HasKey(e => e.MealId).HasName("PK__Meal__ACF6A63DE8558B1A");

            entity.ToTable("Meal");

            entity.HasIndex(e => e.MealName, "u_Meal_MealName").IsUnique();

            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.MealDesc)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.MealName)
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.HasOne(d => d.User).WithMany(p => p.Meals)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("f_Users_Meal");
        });

        modelBuilder.Entity<MealCourse>(entity =>
        {
            entity.HasKey(e => e.MealCourseId).HasName("PK__MealCour__6D1ED3BB6C906F1C");

            entity.ToTable("MealCourse");

            entity.HasIndex(e => new { e.MealId, e.CourseId }, "u_MealCourse_MealId_CourseId").IsUnique();

            entity.HasOne(d => d.Course).WithMany(p => p.MealCourses)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("f_Course_MealCourse");

            entity.HasOne(d => d.Meal).WithMany(p => p.MealCourses)
                .HasForeignKey(d => d.MealId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("f_Meal_MealCourse");
        });

        modelBuilder.Entity<MealCourseRecipe>(entity =>
        {
            entity.HasKey(e => e.MealCourseRecipeId).HasName("PK__MealCour__9D1B764CCE7F213D");

            entity.ToTable("MealCourseRecipe");

            entity.HasIndex(e => new { e.MealCourseId, e.RecipeId }, "u_MealCourseRecipe_MealCourseId_RecipeId").IsUnique();

            entity.HasOne(d => d.MealCourse).WithMany(p => p.MealCourseRecipes)
                .HasForeignKey(d => d.MealCourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("f_MealCourse_MealCourseRecipe");

            entity.HasOne(d => d.Recipe).WithMany(p => p.MealCourseRecipes)
                .HasForeignKey(d => d.RecipeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("f_Recipe_MealCourseRecipe");
        });

        modelBuilder.Entity<Measurement>(entity =>
        {
            entity.HasKey(e => e.MeasurementId).HasName("PK__Measurem__85599FB89E007EE9");

            entity.ToTable("Measurement");

            entity.HasIndex(e => e.MeasurementName, "u_Measurement_MeasurementName").IsUnique();

            entity.Property(e => e.MeasurementName)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Recipe>(entity =>
        {
            entity.HasKey(e => e.RecipeId).HasName("PK__Recipe__FDD988B0BAB27E7A");

            entity.ToTable("Recipe");

            entity.HasIndex(e => e.RecipeName, "c_Recipe_RecipeName").IsUnique();

            entity.Property(e => e.CurrentStatus)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasComputedColumnSql("(case when [DateArchived] IS NULL then case when [DatePublished] IS NULL then 'Draft' else 'Published' end else 'Archived' end)", true);
            entity.Property(e => e.DateArchived).HasColumnType("datetime");
            entity.Property(e => e.DateDrafted).HasColumnType("datetime");
            entity.Property(e => e.DatePublished).HasColumnType("datetime");
            entity.Property(e => e.RecipeName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RecipePicture)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasComputedColumnSql("(concat('recipe_',translate([RecipeName],' ','_'),'.jpg'))", true);

            entity.HasOne(d => d.CuisineType).WithMany(p => p.Recipes)
                .HasForeignKey(d => d.CuisineTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("f_CuisineType_Recipe");

            entity.HasOne(d => d.User).WithMany(p => p.Recipes)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("f_Users_Recipe");
        });

        modelBuilder.Entity<RecipeDirection>(entity =>
        {
            entity.HasKey(e => e.RecipeDirectionsId).HasName("PK__RecipeDi__AF9A5B2895DCFCB5");

            entity.HasIndex(e => new { e.DirectionsSequence, e.RecipeId }, "u_RecipeDirections_DirectionsSequence_RecipeId").IsUnique();

            entity.Property(e => e.Directions)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Recipe).WithMany(p => p.RecipeDirections)
                .HasForeignKey(d => d.RecipeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("f_Recipe_RecipeDirections");
        });

        modelBuilder.Entity<RecipeIngredient>(entity =>
        {
            entity.HasKey(e => e.RecipeIngredientId).HasName("PK__RecipeIn__A2C34216DC5EA7A4");

            entity.ToTable("RecipeIngredient");

            entity.HasIndex(e => new { e.IngredientId, e.RecipeId }, "u_Recipe_IngredientId_RecipeId").IsUnique();

            entity.HasIndex(e => new { e.IngredientSequence, e.RecipeId }, "u_Recipe_IngredientSequence_RecipeId").IsUnique();

            entity.Property(e => e.Amount).HasColumnType("decimal(4, 2)");

            entity.HasOne(d => d.Ingredient).WithMany(p => p.RecipeIngredients)
                .HasForeignKey(d => d.IngredientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("f_Ingredient_RecipeIngredient");

            entity.HasOne(d => d.Measurement).WithMany(p => p.RecipeIngredients)
                .HasForeignKey(d => d.MeasurementId)
                .HasConstraintName("f_Measurement_RecipeIngredient");

            entity.HasOne(d => d.Recipe).WithMany(p => p.RecipeIngredients)
                .HasForeignKey(d => d.RecipeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("f_Recipe_RecipeIngredient");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CC4C7AAF0C3A");

            entity.HasIndex(e => e.UserName, "u_Users_UserName").IsUnique();

            entity.Property(e => e.UserFirstName)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.UserLastName)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
