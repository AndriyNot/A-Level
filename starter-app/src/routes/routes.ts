import UsersPage from "../pages/user/UsersPage";
import ResourcePage from "../pages/resource/ResourcePage";
import RegistrationPage from "../pages/register/RegistrationPage";
import { FC } from "react";

interface Route {
  key: string;
  title: string;
  path: string;
  enabled: boolean;
  element: FC<{}>;
}

const routes: Array<Route> = [
  {
    key: "users",
    title: "Users",
    path: "/users",
    enabled: true,
    element: UsersPage,
  },
  {
    key: "resources",
    title: "Resources",
    path: "/resources",
    enabled: true,
    element: ResourcePage,
  },
  {
    key: "registration", 
    title: "Registration", 
    path: "/registration", 
    enabled: true, 
    element: RegistrationPage, 
  },
];

export default routes;