import { Outlet } from "react-router-dom";

export default function MainLayout() {
  return (
    <div>
      <h1>ATT SaaS Platform</h1>
      <Outlet />
    </div>
  );
}