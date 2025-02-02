package com.app.project.model;


import org.json.JSONException;
import org.json.JSONObject;

import java.io.Serializable;


public class Role implements Serializable {
    private Integer roleId;
    private String roleName;


    public Role(JSONObject obj) throws JSONException {
        this.roleId = obj.optInt("roleId");
        this.roleName = obj.optString("roleName");
    }


    public Integer getRoleId() {
        return roleId;
    }

    public void setRoleId(Integer roleId) {
        this.roleId = roleId;
    }

    public String getRoleName() {
        return roleName;
    }

    public void setRoleName(String roleName) {
        this.roleName = roleName;
    }
}
