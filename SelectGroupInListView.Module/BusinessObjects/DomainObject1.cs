using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using System.Collections.Generic;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace SelectGroupInListView.Module.BusinessObjects
{
    [DefaultClassOptions]
    [ImageName("BO_Contact")]
    public class DomainObject1 : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public DomainObject1(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        string _property1;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Property1
        {
            get => _property1;
            set => SetPropertyValue(nameof(Property1), ref _property1, value);
        }

        string _property2;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Property2
        {
            get => _property2;
            set => SetPropertyValue(nameof(Property2), ref _property2, value);
        }

        bool _active;
        public bool Active
        {
            get => _active;
            set => SetPropertyValue(nameof(Active), ref _active, value);
        }

        DateTime _randomDate;
        public DateTime RandomDate
        {
            get => _randomDate;
            set => SetPropertyValue(nameof(RandomDate), ref _randomDate, value);
        }

        decimal _randomDecimal;
        public decimal RandomDecimal
        {
            get => _randomDecimal;
            set => SetPropertyValue(nameof(RandomDecimal), ref _randomDecimal, value);
        }
    }
}