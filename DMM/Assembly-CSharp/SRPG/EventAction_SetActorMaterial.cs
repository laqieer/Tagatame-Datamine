// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_SetActorMaterial
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001235")]
  [EventActionInfo("New/アクター/マテリアル変更", "マテリアルプロパティーを変更", 5592405, 4473992)]
  public class EventAction_SetActorMaterial : EventAction
  {
    [Token(Token = "0x40042F7")]
    [FieldOffset(Offset = "0x18")]
    [StringIsActorList]
    public string ActorID;
    [Token(Token = "0x40042F8")]
    [FieldOffset(Offset = "0x1C")]
    [HideInInspector]
    public bool allMaterials;
    [Token(Token = "0x40042F9")]
    [FieldOffset(Offset = "0x20")]
    [HideInInspector]
    public string materialName;
    [Token(Token = "0x40042FA")]
    [FieldOffset(Offset = "0x24")]
    [HideInInspector]
    public bool changeTexture;
    [Token(Token = "0x40042FB")]
    [FieldOffset(Offset = "0x28")]
    [HideInInspector]
    public Texture2D texture;
    [Token(Token = "0x40042FC")]
    [FieldOffset(Offset = "0x2C")]
    [HideInInspector]
    public EventAction_SetActorMaterial.ColorModes mode;
    [Token(Token = "0x40042FD")]
    [FieldOffset(Offset = "0x30")]
    [HideInInspector]
    public Color blendColor;

    [Token(Token = "0x6004D27")]
    [Address(RVA = "0x122F4B0", Offset = "0x122E2B0", VA = "0x1122F4B0", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004D28")]
    [Address(RVA = "0x122F7A0", Offset = "0x122E5A0", VA = "0x1122F7A0")]
    public EventAction_SetActorMaterial()
    {
    }

    [Token(Token = "0x2001236")]
    public enum ColorModes
    {
      [Token(Token = "0x40042FF")] None,
      [Token(Token = "0x4004300")] Monochrome,
      [Token(Token = "0x4004301")] Blend,
    }
  }
}
