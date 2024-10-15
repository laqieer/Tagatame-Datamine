// Decompiled with JetBrains decompiler
// Type: PermissionManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using GR;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x200013B")]
[AddComponentMenu("Common/PermissionManager")]
public class PermissionManager : MonoSingleton<PermissionManager>
{
  [Token(Token = "0x4000583")]
  public const string PERMISSION_ID_WRITE_EXTERNAL_STORAGE = "android.permission.WRITE_EXTERNAL_STORAGE";
  [Token(Token = "0x4000584")]
  public const string PERMISSION_ID_LOCATION = "android.permission.ACCESS_FINE_LOCATION";
  [Token(Token = "0x4000585")]
  public const string PERMISSION_ID_NOTIFICATIONS = "android.permission.POST_NOTIFICATIONS";
  [Token(Token = "0x4000586")]
  public const string PERMISSION_NAME_WRITE_EXTERNAL_STORAGE = "embed.PERMISSION_NAME_WRITE_EXTERNAL_STORAGE";
  [Token(Token = "0x4000587")]
  public const string PERMISSION_NAME_LOCATION = "embed.PERMISSION_NAME_LOCATION";
  [Token(Token = "0x4000588")]
  public const string PERMISSION_NAME_NOTIFACATIONS = "embed.PERMISSION_NAME_NOTIFICATIONS";
  [Token(Token = "0x4000589")]
  [FieldOffset(Offset = "0xC")]
  private PermissionManager.OnRequestPermissionResult onRequestPermissionResult;
  [Token(Token = "0x400058A")]
  [FieldOffset(Offset = "0x10")]
  private IPermissionListener m_Listener;

  [Token(Token = "0x60007BE")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  private void Awake()
  {
  }

  [Token(Token = "0x60007BF")]
  [Address(RVA = "0xE4E4D0", Offset = "0xE4D2D0", VA = "0x10E4E4D0")]
  private void OnApplicationPause(bool pause)
  {
  }

  [Token(Token = "0x60007C0")]
  [Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0")]
  public bool hasPermission(ePermissionTypes permissionType) => new bool();

  [Token(Token = "0x60007C1")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  public void requestPermission(
    ePermissionTypes permissionType,
    PermissionManager.OnRequestPermissionResult callback)
  {
  }

  [Token(Token = "0x60007C2")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  public void openApplicationConfig()
  {
  }

  [Token(Token = "0x60007C3")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  private static void setListener(IPermissionListener listener)
  {
  }

  [Token(Token = "0x60007C4")]
  [Address(RVA = "0xE4E2C0", Offset = "0xE4D0C0", VA = "0x10E4E2C0")]
  public static string GetPermissionID(ePermissionTypes permissionType) => (string) null;

  [Token(Token = "0x60007C5")]
  [Address(RVA = "0xE4E340", Offset = "0xE4D140", VA = "0x10E4E340")]
  public static string GetPermissionNameText(ePermissionTypes permissionType) => (string) null;

  [Token(Token = "0x60007C6")]
  [Address(RVA = "0xE4E420", Offset = "0xE4D220", VA = "0x10E4E420")]
  public static bool GetPermissionTypeFromID(
    string permissionID,
    ref ePermissionTypes permissionType)
  {
    return new bool();
  }

  [Token(Token = "0x60007C7")]
  [Address(RVA = "0xE4E640", Offset = "0xE4D440", VA = "0x10E4E640")]
  public PermissionManager()
  {
  }

  [Token(Token = "0x200013C")]
  public delegate void OnRequestPermissionResult(PermissionResultData permissionResultData);
}
