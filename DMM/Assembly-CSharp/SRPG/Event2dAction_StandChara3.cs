// Decompiled with JetBrains decompiler
// Type: SRPG.Event2dAction_StandChara3
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20012B8")]
  [EventActionInfo("New/立ち絵2/配置3(2D)", "立ち絵2を配置します", 5592405, 4473992)]
  public class Event2dAction_StandChara3 : EventAction
  {
    [Token(Token = "0x40045BB")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string AssetPath;
    [Token(Token = "0x40045BC")]
    [FieldOffset(Offset = "0x18")]
    public string CharaID;
    [Token(Token = "0x40045BD")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject StandTemplate;
    [Token(Token = "0x40045BE")]
    [FieldOffset(Offset = "0x20")]
    private string DummyID;
    [Token(Token = "0x40045BF")]
    [FieldOffset(Offset = "0x24")]
    public bool NewMaterial;
    [Token(Token = "0x40045C0")]
    [FieldOffset(Offset = "0x28")]
    private GameObject mStandObject;
    [Token(Token = "0x40045C1")]
    [FieldOffset(Offset = "0x2C")]
    private EventStandCharaController2 mEVCharaController;
    [Token(Token = "0x40045C2")]
    [FieldOffset(Offset = "0x4")]
    private static readonly Vector2 START_POSITION;
    [Token(Token = "0x40045C3")]
    private const string SHADER_NAME = "UI/Custom/EventStandChara";
    [Token(Token = "0x40045C4")]
    private const string PROPERTYNAME_SCALE_X = "_ScaleX";
    [Token(Token = "0x40045C5")]
    private const string PROPERTYNAME_SCALE_Y = "_ScaleY";
    [Token(Token = "0x40045C6")]
    private const string PROPERTYNAME_OFFSET_X = "_OffsetX";
    [Token(Token = "0x40045C7")]
    private const string PROPERTYNAME_OFFSET_Y = "_OffsetY";
    [Token(Token = "0x40045C8")]
    private const string PROPERTYNAME_FACE_TEX = "_FaceTex";

    [Token(Token = "0x6004F61")]
    [Address(RVA = "0x1246760", Offset = "0x1245560", VA = "0x11246760", Slot = "15")]
    public override void PreStart()
    {
    }

    [Token(Token = "0x6004F62")]
    [Address(RVA = "0x1247100", Offset = "0x1245F00", VA = "0x11247100")]
    private bool SetMaterialProperty(Material material, string name, float val) => new bool();

    [Token(Token = "0x6004F63")]
    [Address(RVA = "0x12470C0", Offset = "0x1245EC0", VA = "0x112470C0")]
    private bool SetMaterialProperty(Material material, string name, Texture val) => new bool();

    [Token(Token = "0x6004F64")]
    [Address(RVA = "0x1246600", Offset = "0x1245400", VA = "0x11246600", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004F65")]
    [Address(RVA = "0x12466D0", Offset = "0x12454D0", VA = "0x112466D0", Slot = "7")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x6004F66")]
    [Address(RVA = "0x12471C0", Offset = "0x1245FC0", VA = "0x112471C0")]
    public Event2dAction_StandChara3()
    {
    }

    [Token(Token = "0x6004F67")]
    [Address(RVA = "0x1247150", Offset = "0x1245F50", VA = "0x11247150")]
    static Event2dAction_StandChara3()
    {
    }
  }
}
