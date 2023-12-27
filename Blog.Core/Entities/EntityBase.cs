using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.Entities
{
	public abstract class EntityBase :IEntityBase
	{
		public virtual Guid Id { get; set; } = Guid.NewGuid(); //int seçsem birer birer artar ancak guid olunca öyle değil

		public virtual string CreatedBy { get; set; } = "Undefined";

		//boş geçilebiliyor oluştuğunda her zaman düzenlemek veya silmek istemeyebilirim
		public virtual string? ModidifiedBy { get; set; }
		public virtual string? DeletedBy { get; set; }
			   
		public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
		public virtual DateTime? ModifiedDate { get; set; }
		public virtual DateTime? DeletedDate { get; set; }

		//makalenin var olup olmadığı
		public virtual bool IsDeleted { get; set; } = false;
	}
}
