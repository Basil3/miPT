//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace miPT_Project_6.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    public partial class Workouts
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Workouts()
        {
            this.UserWorkouts = new HashSet<UserWorkouts>();
        }
        [DisplayName("Workout ID")]
        public int WorkoutID { get; set; }
        [DisplayName("Workout Name")]
        public string WorkoutName { get; set; }
        [DisplayName("Description")]
        public string Description { get; set; }
        [DisplayName("YouTube Link")]
        public string YouTubeLink { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserWorkouts> UserWorkouts { get; set; }
    }
}
