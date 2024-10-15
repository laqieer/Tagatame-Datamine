// Decompiled with JetBrains decompiler
// Type: SRPG.RigSetup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20010E8")]
  public class RigSetup : ScriptableObject
  {
    [Token(Token = "0x4003D10")]
    [FieldOffset(Offset = "0xC")]
    public string RootBoneName;
    [Token(Token = "0x4003D11")]
    [FieldOffset(Offset = "0x10")]
    public RigSetup.SkeletonInfo[] Skeletons;
    [Token(Token = "0x4003D12")]
    [FieldOffset(Offset = "0x14")]
    public string LeftHand;
    [Token(Token = "0x4003D13")]
    [FieldOffset(Offset = "0x18")]
    public List<string> LeftHandChangeLists;
    [Token(Token = "0x4003D14")]
    [FieldOffset(Offset = "0x1C")]
    public string RightHand;
    [Token(Token = "0x4003D15")]
    [FieldOffset(Offset = "0x20")]
    public List<string> RightHandChangeLists;
    [Token(Token = "0x4003D16")]
    [FieldOffset(Offset = "0x24")]
    public string TertiaryPlace;
    [Token(Token = "0x4003D17")]
    [FieldOffset(Offset = "0x28")]
    public List<string> TertiaryPlaceChangeLists;
    [Token(Token = "0x4003D18")]
    [FieldOffset(Offset = "0x2C")]
    public List<string> OptionAttachLists;
    [Token(Token = "0x4003D19")]
    [FieldOffset(Offset = "0x30")]
    public float EquipmentScale;
    [Token(Token = "0x4003D1A")]
    [FieldOffset(Offset = "0x34")]
    [Description("この骨格の基準となる身長です")]
    public float Height;
    [Token(Token = "0x4003D1B")]
    [FieldOffset(Offset = "0x38")]
    public string Head;

    [Token(Token = "0x600477E")]
    [Address(RVA = "0x11E9530", Offset = "0x11E8330", VA = "0x111E9530")]
    public RigSetup()
    {
    }

    [Token(Token = "0x20010E9")]
    [Serializable]
    public class BoneInfo
    {
      [Token(Token = "0x4003D1C")]
      [FieldOffset(Offset = "0x8")]
      public string name;
      [Token(Token = "0x4003D1D")]
      [FieldOffset(Offset = "0xC")]
      public Vector3 offset;
      [Token(Token = "0x4003D1E")]
      [FieldOffset(Offset = "0x18")]
      public Vector3 scale;

      [Token(Token = "0x600477F")]
      [Address(RVA = "0x11DCAD0", Offset = "0x11DB8D0", VA = "0x111DCAD0")]
      public BoneInfo()
      {
      }
    }

    [Token(Token = "0x20010EA")]
    [Serializable]
    public class SkeletonInfo
    {
      [Token(Token = "0x4003D1F")]
      [FieldOffset(Offset = "0x8")]
      public string name;
      [Token(Token = "0x4003D20")]
      [FieldOffset(Offset = "0xC")]
      public RigSetup.BoneInfo[] bones;

      [Token(Token = "0x6004780")]
      [Address(RVA = "0x11E9B30", Offset = "0x11E8930", VA = "0x111E9B30")]
      public SkeletonInfo()
      {
      }
    }
  }
}
