using System.ComponentModel.DataAnnotations;

namespace ProductPortal.Data.Models
{
    public class Product
    {
        public Product()
        {
            Name = string.Empty;
            _image = string.Empty;
            CreateDate = DateTime.Now;
            CreateUser = string.Empty;
            _modifiedUser = string.Empty;
            _internalNotes = string.Empty;
        }
        /// <summary>
        /// discriminator - false : normaal product, true : eigen velden e.d.
        /// </summary>
        public bool? Discriminator { get; set; }

        private string _image;
        private DateTime? _modifiedDate;
        private string _modifiedUser;
        private string _internalNotes;

        [Key]
        public int ProductId { get; set; }

        [Required]
        public string Name { get; set; }

        public string? Image { get => _image; set { _image = Convert.IsDBNull(_image) ? string.Empty : _image; } }

        [Required]
        public DateTime CreateDate { get; set; }

        [Required]
        public string CreateUser { get; set; }

        public DateTime? ModifiedDate { get => _modifiedDate; set { _modifiedDate = Convert.IsDBNull(value) ? null : value; } }

        public string? ModifiedUser { get => _modifiedUser; set { _modifiedUser = Convert.IsDBNull(value) ? string.Empty : value; } }

        [Required]
        public int State { get; set; }

        public string? InternalNotes { get => _internalNotes; set { _internalNotes = Convert.IsDBNull(value) ? string.Empty : value; } }

    }
}
