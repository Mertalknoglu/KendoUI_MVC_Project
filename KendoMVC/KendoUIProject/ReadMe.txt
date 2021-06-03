Enttity Model güncellendiğinde "task.cs" class'ında guncellenmesi gereken date alanlarda aşağıdaki gibi attribute tanımlanmalı.
yapı mevcuttur. 

 public partial class task
    {
        public int id { get; set; }
        public string talepno { get; set; }
        public string isadi { get; set; }
        [DataType(DataType.Date)]
        public DateTime? bildirimtarih { get; set; }
        [DataType(DataType.Date)] 
        public DateTime? cozumtarih { get; set; }
        public string issahibi { get; set; }
        public Nullable<byte> durum { get; set; }
    }