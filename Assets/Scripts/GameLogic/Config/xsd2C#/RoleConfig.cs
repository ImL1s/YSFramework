﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34209
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// 此源代码由 xsd 自动生成, Version=4.0.30319.33440。
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class RoleConfig {
    
    private RoleConfigRace[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Race", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public RoleConfigRace[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class RoleConfigRace {
    
    private RoleConfigRaceProfession[] professionField;
    
    private string raceENameField;
    
    private string raceCNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Profession", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public RoleConfigRaceProfession[] Profession {
        get {
            return this.professionField;
        }
        set {
            this.professionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string RaceEName {
        get {
            return this.raceENameField;
        }
        set {
            this.raceENameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string RaceCName {
        get {
            return this.raceCNameField;
        }
        set {
            this.raceCNameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class RoleConfigRaceProfession {
    
    private string professionENameField;
    
    private string professionCNameField;
    
    private string modelNameField;
    
    private string desField;
    
    private string attackField;
    
    private string defField;
    
    private string distanceField;
    
    private string controlField;
    
    private string helpField;
    
    private string liveField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ProfessionEName {
        get {
            return this.professionENameField;
        }
        set {
            this.professionENameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ProfessionCName {
        get {
            return this.professionCNameField;
        }
        set {
            this.professionCNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ModelName {
        get {
            return this.modelNameField;
        }
        set {
            this.modelNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Des {
        get {
            return this.desField;
        }
        set {
            this.desField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Attack {
        get {
            return this.attackField;
        }
        set {
            this.attackField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Def {
        get {
            return this.defField;
        }
        set {
            this.defField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Distance {
        get {
            return this.distanceField;
        }
        set {
            this.distanceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Control {
        get {
            return this.controlField;
        }
        set {
            this.controlField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Help {
        get {
            return this.helpField;
        }
        set {
            this.helpField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Live {
        get {
            return this.liveField;
        }
        set {
            this.liveField = value;
        }
    }
}
