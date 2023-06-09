import { proxyTexts } from "@serenity-is/corelib/q";

namespace SMarketPlace.Texts {

    export declare namespace Db {

        namespace Administration {

            namespace Language {
                export const Id: string;
                export const LanguageId: string;
                export const LanguageName: string;
            }

            namespace Role {
                export const RoleId: string;
                export const RoleName: string;
            }

            namespace RolePermission {
                export const PermissionKey: string;
                export const RoleId: string;
                export const RolePermissionId: string;
                export const RoleRoleName: string;
            }

            namespace Translation {
                export const CustomText: string;
                export const EntityPlural: string;
                export const Key: string;
                export const OverrideConfirmation: string;
                export const SaveChangesButton: string;
                export const SourceLanguage: string;
                export const SourceText: string;
                export const TargetLanguage: string;
                export const TargetText: string;
            }

            namespace User {
                export const DisplayName: string;
                export const Email: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const LastDirectoryUpdate: string;
                export const Password: string;
                export const PasswordConfirm: string;
                export const PasswordHash: string;
                export const PasswordSalt: string;
                export const Roles: string;
                export const Source: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
                export const UserId: string;
                export const UserImage: string;
                export const Username: string;
            }

            namespace UserPermission {
                export const Granted: string;
                export const PermissionKey: string;
                export const User: string;
                export const UserId: string;
                export const UserPermissionId: string;
                export const Username: string;
            }

            namespace UserRole {
                export const RoleId: string;
                export const User: string;
                export const UserId: string;
                export const UserRoleId: string;
                export const Username: string;
            }
        }

        namespace Ecommerce {

            namespace Promociones {
                export const Alcanceas: string;
                export const Beneficio: string;
                export const CantidadBeneficio: string;
                export const CantidadRequisito: string;
                export const DescripcionCorta: string;
                export const DescripcionPromocion: string;
                export const FinVigencia: string;
                export const Id: string;
                export const IdOrder: string;
                export const IdPromocion: string;
                export const InicioVigencia: string;
                export const LealtadCodigoAcumula: string;
                export const LealtadLimitePeriodicidad: string;
                export const LealtadLimitePiezas: string;
                export const MapCod: string;
                export const Mecanica: string;
                export const MostrarPrecioRebajado: string;
                export const NroLocal: string;
                export const ZonaVisualizacion: string;
            }
        }

        namespace JobMP {

            namespace AsignaSucursal {
                export const IdMp: string;
                export const IdSucurasalMp: string;
                export const IdSucursal: string;
                export const IdSucursalLocalSap: string;
            }

            namespace JobSucursales {
                export const Activo: string;
                export const Descripcion: string;
                export const Diario: string;
                export const Dias: string;
                export const FechaInicio: string;
                export const Hora: string;
                export const IdMp: string;
                export const IdMpNombreMp: string;
                export const Idintegrador: string;
                export const IdintegradorNombre: string;
                export const NombreMp: string;
            }

            namespace MarketPlace {
                export const Activo: string;
                export const Clase: string;
                export const Descripcion: string;
                export const FechaInicio: string;
                export const Idintegrador: string;
                export const Nombre: string;
            }
        }

        namespace Log {

            namespace LogProcesos {
                export const Activo: string;
                export const Descripcion: string;
                export const FechaInicio: string;
                export const IdLog: string;
                export const Integrador: string;
                export const Proceso: string;
            }
        }

        namespace Productos {

            namespace TblArticulo {
                export const Categoria: string;
                export const Categorialealtad: string;
                export const Codbar: string;
                export const Division: string;
                export const Grupo: string;
                export const Iva: string;
                export const MapMod: string;
                export const Nombrearticulo: string;
                export const ParametroProducto: string;
                export const Precio: string;
                export const Proveedor: string;
                export const Sku: string;
                export const Subcategoria: string;
            }

            namespace TblproductosDidi {
                export const IntArticuloid: string;
                export const NombreArticulo: string;
            }

            namespace TblproductosRappi {
                export const IntArticuloid: string;
                export const NombreArticulo: string;
            }

            namespace TblproductosUber {
                export const IntArticuloid: string;
                export const NombreArticulo: string;
            }
        }

        namespace Sucursales {

            namespace TblSucursal {
                export const Ciudad: string;
                export const Codigopostal: string;
                export const Direccion: string;
                export const Estado: string;
                export const IdSucursal: string;
                export const LocalSap: string;
                export const NombreSuc: string;
                export const Pais: string;
                export const Region: string;
                export const Zona: string;
            }

            namespace TblSucursalDidi {
                export const LocalSap: string;
                export const NombreSucursal: string;
            }

            namespace TblSucursalRappi {
                export const LocalSap: string;
                export const NombreSucursal: string;
            }

            namespace TblSucursalUber {
                export const LocalSap: string;
                export const NombreSucursal: string;
            }
        }
    }

    export declare namespace Forms {

        namespace Membership {

            namespace ChangePassword {
                export const FormTitle: string;
                export const SubmitButton: string;
                export const Success: string;
            }

            namespace ForgotPassword {
                export const BackToLogin: string;
                export const FormInfo: string;
                export const FormTitle: string;
                export const SubmitButton: string;
                export const SuccessMessage: string;
            }

            namespace Login {
                export const FacebookButton: string;
                export const ForgotPassword: string;
                export const GoogleButton: string;
                export const LoginToYourAccount: string;
                export const OR: string;
                export const RememberMe: string;
                export const SignInButton: string;
                export const SignUpButton: string;
            }

            namespace ResetPassword {
                export const BackToLogin: string;
                export const EmailSubject: string;
                export const FormTitle: string;
                export const SubmitButton: string;
                export const Success: string;
            }

            namespace SignUp {
                export const AcceptTerms: string;
                export const ActivateEmailSubject: string;
                export const ActivationCompleteMessage: string;
                export const BackToLogin: string;
                export const ConfirmEmail: string;
                export const ConfirmPassword: string;
                export const DisplayName: string;
                export const Email: string;
                export const FormInfo: string;
                export const FormTitle: string;
                export const Password: string;
                export const SubmitButton: string;
                export const Success: string;
            }
        }
    }

    export declare namespace Navigation {
        export const LogoutLink: string;
        export const SiteTitle: string;
    }

    export declare namespace Site {

        namespace AccessDenied {
            export const ClickToChangeUser: string;
            export const ClickToLogin: string;
            export const LackPermissions: string;
            export const NotLoggedIn: string;
            export const PageTitle: string;
        }

        namespace BasicProgressDialog {
            export const CancelTitle: string;
            export const PleaseWait: string;
        }

        namespace BulkServiceAction {
            export const AllHadErrorsFormat: string;
            export const AllSuccessFormat: string;
            export const ConfirmationFormat: string;
            export const ErrorCount: string;
            export const NothingToProcess: string;
            export const SomeHadErrorsFormat: string;
            export const SuccessCount: string;
        }

        namespace Dashboard {
            export const ContentDescription: string;
        }

        namespace Layout {
            export const FooterCopyright: string;
            export const FooterInfo: string;
            export const FooterRights: string;
            export const GeneralSettings: string;
            export const Language: string;
            export const Theme: string;
            export const ThemeBlack: string;
            export const ThemeBlackLight: string;
            export const ThemeBlue: string;
            export const ThemeBlueLight: string;
            export const ThemeGreen: string;
            export const ThemeGreenLight: string;
            export const ThemePurple: string;
            export const ThemePurpleLight: string;
            export const ThemeRed: string;
            export const ThemeRedLight: string;
            export const ThemeYellow: string;
            export const ThemeYellowLight: string;
        }

        namespace RolePermissionDialog {
            export const DialogTitle: string;
            export const EditButton: string;
            export const SaveSuccess: string;
        }

        namespace UserDialog {
            export const EditPermissionsButton: string;
            export const EditRolesButton: string;
        }

        namespace UserPermissionDialog {
            export const DialogTitle: string;
            export const Grant: string;
            export const Permission: string;
            export const Revoke: string;
            export const SaveSuccess: string;
        }

        namespace UserRoleDialog {
            export const DialogTitle: string;
            export const SaveSuccess: string;
        }

        namespace ValidationError {
            export const Title: string;
        }
    }

    export declare namespace Validation {
        export const AuthenticationError: string;
        export const CurrentPasswordMismatch: string;
        export const DeleteForeignKeyError: string;
        export const EmailConfirm: string;
        export const EmailInUse: string;
        export const InvalidActivateToken: string;
        export const InvalidResetToken: string;
        export const MinRequiredPasswordLength: string;
        export const PasswordConfirmMismatch: string;
        export const SavePrimaryKeyError: string;
    }

    SMarketPlace['Texts'] = proxyTexts(Texts, '', {Db:{Administration:{Language:{Id:1,LanguageId:1,LanguageName:1},Role:{RoleId:1,RoleName:1},RolePermission:{PermissionKey:1,RoleId:1,RolePermissionId:1,RoleRoleName:1},Translation:{CustomText:1,EntityPlural:1,Key:1,OverrideConfirmation:1,SaveChangesButton:1,SourceLanguage:1,SourceText:1,TargetLanguage:1,TargetText:1},User:{DisplayName:1,Email:1,InsertDate:1,InsertUserId:1,IsActive:1,LastDirectoryUpdate:1,Password:1,PasswordConfirm:1,PasswordHash:1,PasswordSalt:1,Roles:1,Source:1,UpdateDate:1,UpdateUserId:1,UserId:1,UserImage:1,Username:1},UserPermission:{Granted:1,PermissionKey:1,User:1,UserId:1,UserPermissionId:1,Username:1},UserRole:{RoleId:1,User:1,UserId:1,UserRoleId:1,Username:1}},Ecommerce:{Promociones:{Alcanceas:1,Beneficio:1,CantidadBeneficio:1,CantidadRequisito:1,DescripcionCorta:1,DescripcionPromocion:1,FinVigencia:1,Id:1,IdOrder:1,IdPromocion:1,InicioVigencia:1,LealtadCodigoAcumula:1,LealtadLimitePeriodicidad:1,LealtadLimitePiezas:1,MapCod:1,Mecanica:1,MostrarPrecioRebajado:1,NroLocal:1,ZonaVisualizacion:1}},JobMP:{AsignaSucursal:{IdMp:1,IdSucurasalMp:1,IdSucursal:1,IdSucursalLocalSap:1},JobSucursales:{Activo:1,Descripcion:1,Diario:1,Dias:1,FechaInicio:1,Hora:1,IdMp:1,IdMpNombreMp:1,Idintegrador:1,IdintegradorNombre:1,NombreMp:1},MarketPlace:{Activo:1,Clase:1,Descripcion:1,FechaInicio:1,Idintegrador:1,Nombre:1}},Log:{LogProcesos:{Activo:1,Descripcion:1,FechaInicio:1,IdLog:1,Integrador:1,Proceso:1}},Productos:{TblArticulo:{Categoria:1,Categorialealtad:1,Codbar:1,Division:1,Grupo:1,Iva:1,MapMod:1,Nombrearticulo:1,ParametroProducto:1,Precio:1,Proveedor:1,Sku:1,Subcategoria:1},TblproductosDidi:{IntArticuloid:1,NombreArticulo:1},TblproductosRappi:{IntArticuloid:1,NombreArticulo:1},TblproductosUber:{IntArticuloid:1,NombreArticulo:1}},Sucursales:{TblSucursal:{Ciudad:1,Codigopostal:1,Direccion:1,Estado:1,IdSucursal:1,LocalSap:1,NombreSuc:1,Pais:1,Region:1,Zona:1},TblSucursalDidi:{LocalSap:1,NombreSucursal:1},TblSucursalRappi:{LocalSap:1,NombreSucursal:1},TblSucursalUber:{LocalSap:1,NombreSucursal:1}}},Forms:{Membership:{ChangePassword:{FormTitle:1,SubmitButton:1,Success:1},ForgotPassword:{BackToLogin:1,FormInfo:1,FormTitle:1,SubmitButton:1,SuccessMessage:1},Login:{FacebookButton:1,ForgotPassword:1,GoogleButton:1,LoginToYourAccount:1,OR:1,RememberMe:1,SignInButton:1,SignUpButton:1},ResetPassword:{BackToLogin:1,EmailSubject:1,FormTitle:1,SubmitButton:1,Success:1},SignUp:{AcceptTerms:1,ActivateEmailSubject:1,ActivationCompleteMessage:1,BackToLogin:1,ConfirmEmail:1,ConfirmPassword:1,DisplayName:1,Email:1,FormInfo:1,FormTitle:1,Password:1,SubmitButton:1,Success:1}}},Navigation:{LogoutLink:1,SiteTitle:1},Site:{AccessDenied:{ClickToChangeUser:1,ClickToLogin:1,LackPermissions:1,NotLoggedIn:1,PageTitle:1},BasicProgressDialog:{CancelTitle:1,PleaseWait:1},BulkServiceAction:{AllHadErrorsFormat:1,AllSuccessFormat:1,ConfirmationFormat:1,ErrorCount:1,NothingToProcess:1,SomeHadErrorsFormat:1,SuccessCount:1},Dashboard:{ContentDescription:1},Layout:{FooterCopyright:1,FooterInfo:1,FooterRights:1,GeneralSettings:1,Language:1,Theme:1,ThemeBlack:1,ThemeBlackLight:1,ThemeBlue:1,ThemeBlueLight:1,ThemeGreen:1,ThemeGreenLight:1,ThemePurple:1,ThemePurpleLight:1,ThemeRed:1,ThemeRedLight:1,ThemeYellow:1,ThemeYellowLight:1},RolePermissionDialog:{DialogTitle:1,EditButton:1,SaveSuccess:1},UserDialog:{EditPermissionsButton:1,EditRolesButton:1},UserPermissionDialog:{DialogTitle:1,Grant:1,Permission:1,Revoke:1,SaveSuccess:1},UserRoleDialog:{DialogTitle:1,SaveSuccess:1},ValidationError:{Title:1}},Validation:{AuthenticationError:1,CurrentPasswordMismatch:1,DeleteForeignKeyError:1,EmailConfirm:1,EmailInUse:1,InvalidActivateToken:1,InvalidResetToken:1,MinRequiredPasswordLength:1,PasswordConfirmMismatch:1,SavePrimaryKeyError:1}}) as any;
}

export const Texts = SMarketPlace.Texts;