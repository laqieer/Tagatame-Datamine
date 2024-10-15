// Decompiled with JetBrains decompiler
// Type: SRPG.CharacterSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E7F")]
  [AddComponentMenu("Common/CharacterSettings")]
  public class CharacterSettings : MonoBehaviour
  {
    [Token(Token = "0x4002C75")]
    [FieldOffset(Offset = "0xC")]
    public RigSetup Rig;
    [Token(Token = "0x4002C76")]
    [FieldOffset(Offset = "0x10")]
    public string DefaultSkeleton;
    [Token(Token = "0x4002C77")]
    [FieldOffset(Offset = "0x14")]
    public Projector ShadowProjector;
    [Token(Token = "0x4002C78")]
    [FieldOffset(Offset = "0x18")]
    public bool IsUseGlowColor;
    [Token(Token = "0x4002C79")]
    [FieldOffset(Offset = "0x1C")]
    public Color32 GlowColor;
    [Token(Token = "0x4002C7A")]
    [FieldOffset(Offset = "0x20")]
    public float GlowStrength;
    [Token(Token = "0x4002C7B")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public float UIDispOffset;
    [Token(Token = "0x4002C7C")]
    [FieldOffset(Offset = "0x28")]
    public string[] RidingModelNames;
    [Token(Token = "0x4002C7D")]
    [FieldOffset(Offset = "0x2C")]
    private CharacterSettings.BoneStateCache[] mBoneStates;
    [Token(Token = "0x4002C7E")]
    [FieldOffset(Offset = "0x30")]
    private RigSetup.SkeletonInfo mActiveSkeleton;

    [Token(Token = "0x17000484")]
    public float Height
    {
      [Token(Token = "0x6003C22"), Address(RVA = "0x10EA910", Offset = "0x10E9710", VA = "0x110EA910")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x6003C23")]
    [Address(RVA = "0x10EA300", Offset = "0x10E9100", VA = "0x110EA300")]
    private void Awake()
    {
    }

    [Token(Token = "0x6003C24")]
    [Address(RVA = "0x10EA4B0", Offset = "0x10E92B0", VA = "0x110EA4B0")]
    public void SetSkeleton(string rigName)
    {
    }

    [Token(Token = "0x6003C25")]
    [Address(RVA = "0x10EA340", Offset = "0x10E9140", VA = "0x110EA340")]
    private void CacheBoneStates()
    {
    }

    [Token(Token = "0x6003C26")]
    [Address(RVA = "0x10EA020", Offset = "0x10E8E20", VA = "0x110EA020")]
    private void AdjustBones()
    {
    }

    [Token(Token = "0x6003C27")]
    [Address(RVA = "0x10EA8D0", Offset = "0x10E96D0", VA = "0x110EA8D0")]
    private void Update()
    {
    }

    [Token(Token = "0x6003C28")]
    [Address(RVA = "0x10EA490", Offset = "0x10E9290", VA = "0x110EA490")]
    private void LateUpdate()
    {
    }

    [Token(Token = "0x6003C29")]
    [Address(RVA = "0x10EA8E0", Offset = "0x10E96E0", VA = "0x110EA8E0")]
    public CharacterSettings()
    {
    }

    [Token(Token = "0x2000E80")]
    private struct BoneStateCache
    {
      [Token(Token = "0x4002C7F")]
      [FieldOffset(Offset = "0x0")]
      public RigSetup.BoneInfo boneInfo;
      [Token(Token = "0x4002C80")]
      [FieldOffset(Offset = "0x4")]
      public Transform transform;
      [Token(Token = "0x4002C81")]
      [FieldOffset(Offset = "0x8")]
      public Vector3 localPosition;
      [Token(Token = "0x4002C82")]
      [FieldOffset(Offset = "0x14")]
      public Vector3 localScale;
    }
  }
}
